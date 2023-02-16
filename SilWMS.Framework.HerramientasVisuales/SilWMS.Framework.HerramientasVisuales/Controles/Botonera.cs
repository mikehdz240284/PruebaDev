using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilWMS.Framework.HerramientasVisuales.Controles
{
    public partial class Botonera : UserControl
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        /// <summary>
        /// Obtine o establece si el boton impresora se va a mostrar
        /// </summary>
        public bool VisibleBtnImpresora
        {
            get { return panelImprimir.Visible; }
            set
            {
                panelImprimir.Visible = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton eliminar se va a mostrar
        /// </summary>
        public bool VisibleBtnEliminar
        {
            get { return panelEliminar.Visible; }
            set
            {
                panelEliminar.Visible = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton actualizar se va a mostrar
        /// </summary>
        public bool VisibleBtnActualizar
        {
            get { return panelActualizar.Visible; }
            set
            {
                panelActualizar.Visible = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton nuevo se va a mostrar
        /// </summary>
        public bool VisibleBtnNuevo
        {
            get { return panelNuevo.Visible; }
            set
            {
                panelNuevo.Visible = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton impresora se va a mostrar
        /// </summary>
        public bool HabilitadoBtnImpresora
        {
            get { return panelImprimir.Enabled; }
            set
            {
                panelImprimir.Enabled = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton eliminar se va a mostrar
        /// </summary>
        public bool HabilitadoBtnEliminar
        {
            get { return panelEliminar.Enabled; }
            set
            {
                panelEliminar.Enabled = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton actualizar se va a mostrar
        /// </summary>
        public bool HabilitadoBtnActualizar
        {
            get { return panelActualizar.Enabled; }
            set
            {
                panelActualizar.Enabled = value;
            }
        }

        /// <summary>
        /// Obtine o establece si el boton nuevo se va a mostrar
        /// </summary>
        public bool HabilitadoBtnNuevo
        {
            get { return panelNuevo.Enabled; }
            set
            {
                panelNuevo.Enabled = value;
            }
        }

        public Botonera()
        {
            InitializeComponent();

            leftBorderBtn = new Panel
            {
                Size = new Size(7, 60)
            };
            panelActualizar.Controls.Add(leftBorderBtn);
            panelEliminar.Controls.Add(leftBorderBtn);
            panelImprimir.Controls.Add(leftBorderBtn);
            panelNuevo.Controls.Add(leftBorderBtn);

            btnImpresora.Click += BtnImpresora_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnNuevo.Click += BtnNuevo_Click;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                ////Current Child Form Icon
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void BtnImpresora_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
    }
}
