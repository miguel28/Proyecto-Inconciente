using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SystemGameCore;

namespace LevelEditor
{
    public partial class frmLevelEditor : Form
    {
        public frmLevelEditor()
        {
            InitializeComponent();

            //Graphics g = Graphics.FromImage(tempImage);
            //g.Clear(Color.White);
            picLevelDesign.Image = tempImage;
        }

        #region ToolStrip Events

        private void btnAddTileSets_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files |*.jpg;*.png;*.bmp;*.gif";
            dialog.Multiselect = true;
            DialogResult result = dialog.ShowDialog();

            if (DialogResult.OK == result)
            {
                foreach (string filename in dialog.FileNames)
                {
                    if (!TileSetsPaths.Contains(filename))
                    {
                        TileSetsPaths.Add(filename);
                    }
                }
                UpdateTileSetsCombo();
            }
        }

        #endregion

        #region TileSetsTool
        private List<string> TileSetsPaths = new List<string>();
        private Image TileSet;
        private Image DashedTileSet;
        private Color TileTransparentColor;
        
        private void UpdateTileSetsCombo()
        {
            cboxTileSetSelect.Items.Clear();
            TileSetsPaths.ForEach(x => cboxTileSetSelect.Items.Add(Path.GetFileName(x)));

            if (cboxTileSetSelect.Items.Count > 0)
                cboxTileSetSelect.SelectedIndex = 0;
        }

        private void OpenTileSet(string path)
        {
            Image tilesetimage = new Bitmap(path);
            TileSet = tilesetimage;
            DashedTileSet = (Image)tilesetimage.Clone();

            editingLevel.GridSize = new Size(32, 32);

            Draw.DrawGrid(ref DashedTileSet, editingLevel.GridSize);
            picTileSet.Image = DashedTileSet;

            TileTransparentColor = ((Bitmap)TileSet).GetPixel(0, TileSet.Height-1);
        }

        private void cboxTileSetSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboxTileSetSelect.SelectedIndex;
            if (index >= 0)
            {
                string value = TileSetsPaths[index];
                OpenTileSet(value);
            }
        }

        private Point TileDownClick, TileUpClick;
        private bool TileClicked;
        private Rectangle UnitRectangle;
        private Image TileSelection;

        private void picTileSet_MouseUp(object sender, MouseEventArgs e)
        {
            TileClicked = false;
        
            TileUpClick = e.Location;
            UnitRectangle = Helpers.CalcUnitRectangle(TileDownClick, TileUpClick, editingLevel.GridSize);
            picTileSet.Invalidate();

            Rectangle r = Helpers.GetExpandedRectangle(UnitRectangle, editingLevel.GridSize);
            TileSelection = Draw.ChopImage(TileSet, r);
            picSelectedTile.Image = TileSelection;
        }

        private void picTileSet_MouseDown(object sender, MouseEventArgs e)
        {
            TileDownClick = e.Location;
            TileClicked = true;
        }

        private void picTileSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (TileClicked)
            {
                TileUpClick = e.Location;
                UnitRectangle = Helpers.CalcUnitRectangle(TileDownClick, TileUpClick, editingLevel.GridSize);
                picTileSet.Invalidate();
            }
        }

        private void picTileSet_MouseLeave(object sender, EventArgs e)
        {
            TileClicked = false;
        }

        /// <summary>
        ///  Draws also the selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picTileSet_Paint(object sender, PaintEventArgs e)
        {
            if (!Helpers.IsRectangleNull(UnitRectangle))
            {
                Graphics g = e.Graphics;
                Pen p = new Pen(Color.Yellow,5);
                Rectangle r = Helpers.GetExpandedRectangle(UnitRectangle, editingLevel.GridSize);
                g.DrawRectangle(p, r);
            }
        }
        #endregion

        #region LevelEditor
        private Level editingLevel;
        private Image tempImage = new Bitmap(3200, 3200 / 2);

        private Point TileCursor;

        private void picLevelDesign_MouseClick(object sender, MouseEventArgs e)
        {
            if (editingLevel == null)
                return;

            if (!Helpers.IsRectangleNull(UnitRectangle) && TileSelection != null)
            {
                Point p = Helpers.GetExpandablePoint(TileCursor, editingLevel.GridSize);
                Background layer = editingLevel.Layers[cboxLayers.SelectedIndex];

                if (SelectedEraser)
                {
                    Rectangle r = Helpers.CloneRectangle(UnitRectangle);
                    r.X = TileCursor.X;
                    r.Y = TileCursor.Y;
                    Rectangle r1 = Helpers.GetExpandedRectangle(r, editingLevel.GridSize);

                    layer.BitmapImage = Draw.DrawEmptyRectangle(layer.BitmapImage, r1);
                    editingLevel.Layers[cboxLayers.SelectedIndex] = layer;
                }
                else
                {
                    Graphics g = Graphics.FromImage(layer.BitmapImage);

                    Image toPaint = Draw.SetTransparecy(TileSelection, TileTransparentColor);

                    g.DrawImage(toPaint, p);
                }

                RedrawAllMap();
            }
        }

        private void picLevelDesign_MouseMove(object sender, MouseEventArgs e)
        {
            if (editingLevel == null)
                return;

            if (!Helpers.IsRectangleNull(UnitRectangle) && TileSelection != null)
            {
                Point p = Helpers.CalcUnitPoint(e.Location, editingLevel.GridSize);
                if (!Helpers.IsEqual(p, TileCursor))
                {
                    TileCursor = p;
                    picLevelDesign.Invalidate();
                }
            } 
        }

        private void picLevelDesign_Paint(object sender, PaintEventArgs e)
        {
            if (editingLevel == null)
                return;

            if (!Helpers.IsRectangleNull(UnitRectangle) && TileSelection != null)
            {
                Graphics g = e.Graphics;
                Rectangle r = Helpers.CloneRectangle(UnitRectangle);
                r.X = TileCursor.X;
                r.Y = TileCursor.Y;

                Color c = SelectedEraser ? Color.Red : Color.Green;
                Pen p = new Pen(c, 3);
                Rectangle r1 = Helpers.GetExpandedRectangle(r, editingLevel.GridSize);
                g.DrawRectangle(p, r1);
            }
        }

        private bool SelectedEraser = false;

        private void btnPencil_Click(object sender, EventArgs e)
        {
            SelectedEraser = false;
            btnPencil.BackColor = SystemColors.ControlDark;
            btnEraser.BackColor = SystemColors.Control;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            SelectedEraser = true;
            btnPencil.BackColor = SystemColors.Control;
            btnEraser.BackColor = SystemColors.ControlDark;
        }

        private void cboxLayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RedrawAllMap()
        {
            Image img = editingLevel.GetAllLayers();
            picLevelDesign.Image = img;
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            editingLevel.AddNewLayer();
            UpdateLayersList();

        }

        private void btnDeleteLayer_Click(object sender, EventArgs e)
        {
            editingLevel.RemoveLayer(cboxLayers.SelectedIndex);
            UpdateLayersList();
        }

        private void UpdateLayersList()
        {
            cboxLayers.Items.Clear();
            cboxLayers.Items.AddRange(editingLevel.GetLayersLabels());
            cboxLayers.SelectedIndex = 0;
        }
        #endregion


        #region Menu Methods
        private void newLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diaLevelProperties dialog = new diaLevelProperties(null);
            dialog.ShowDialog();
            Level le = dialog.edLevel;
            if (le != null)
            {
                editingLevel = le;
                UpdateLayersList();

                EnableEditing(true);
            }
        }
        
        private void openLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EnableEditing(bool en)
        {
            toolStrip1.Enabled = en;
            //toolNavigator.Enabled = en;
            newLevelToolStripMenuItem.Enabled = !en;
            openLevelToolStripMenuItem.Enabled = !en;
            closeLevelToolStripMenuItem.Enabled = en;
            saveLevelToolStripMenuItem.Enabled = en;
        }
        #endregion
    }
}
