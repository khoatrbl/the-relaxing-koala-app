using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantIS
{
    public partial class ucPaymentMethod : UserControl
    {
        public ucPaymentMethod()
        {
            InitializeComponent();
        }

        private string method;
        private Image icon;

        [Category("Custom Props")]
        public string Method { get => method; set { method = value; paymentMethodDisplay.Text = value; } }

        [Category("Custom Props")]
        public Image Icon { get => icon; set { icon = value; ptbPaymentMethod.Image = value; } }

        public Label GetMethodDisplay()
        {
            return paymentMethodDisplay;
        }

        public PictureBox GetPictureBox()
        {
            return ptbPaymentMethod;
        }
    }

}
