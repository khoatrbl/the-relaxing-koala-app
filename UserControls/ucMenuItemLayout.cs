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
    public partial class ucMenuItemLayout : UserControl
    {
        public ucMenuItemLayout()
        {
            InitializeComponent();
        }

        private int itemId;
        private string itemName;
        private string itemPrice;
        private Image itemImage;
        private int quantity = 0;

        private void menuItemQuantityCtrl_ValueChanged(object sender, EventArgs e)
        {
            Quantity = (int)menuItemQuantityCtrl.Value;
        }

        [Category("Custom Props")]
        public string ItemName { get => itemName; set { itemName = value; menuItemNameLabel.Text = value; } }

        [Category("Custom Props")]
        public string ItemPrice { get => itemPrice; set { itemPrice = value; menuItemPriceLabel.Text = value; } }

        [Category("Custom Props")]
        public Image ItemImage { get => itemImage; set { itemImage = value; menuItemPtb.Image = value; } }

        [Category("Custom Props")]
        public int Quantity { get => quantity; set { quantity = value; menuItemQuantityCtrl.Value = value; } }

        public int ItemId { get => itemId; set => itemId = value; }
    }
}
