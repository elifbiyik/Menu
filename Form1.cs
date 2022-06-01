using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Menu : Form
    {
        int teaNumber = 0;
        int coffeeNumber = 0;
        int limNumber = 0;
        int sodaNumber = 0;
        int hotcNumber = 0;
        int cheesNumber = 0;
        int tiramisuNumber = 0;


        public Menu()
        {
            InitializeComponent();
        }

        private void button_t_p_Click(object sender, EventArgs e)
        {
            teaNumber++;
            label_tea.Text = Convert.ToString(teaNumber);
        }

        private void button_t_m_Click(object sender, EventArgs e)
        {
            if (teaNumber > 0)
            {
                teaNumber--;
                label_tea.Text = Convert.ToString(teaNumber);
            }
        }

        private void button_c_p_Click(object sender, EventArgs e)
        {
            coffeeNumber++;
            label_coffee.Text = Convert.ToString(coffeeNumber);
        }

        private void button_c_m_Click(object sender, EventArgs e)
        {
            if(coffeeNumber > 0)
            {
                coffeeNumber--;
                label_coffee.Text = Convert.ToString(coffeeNumber);

            }
        }

        private void button_s_p_Click(object sender, EventArgs e)
        {
            sodaNumber++;
            label_soda.Text = Convert.ToString(sodaNumber);
        }

        private void button_s_m_Click(object sender, EventArgs e)
        {
            if(sodaNumber > 0)
            {
                sodaNumber++;
                label_soda.Text = Convert.ToString(sodaNumber);

            }
        }

        private void button_l_p_Click(object sender, EventArgs e)
        {
            limNumber++;
            label_lemonade.Text = Convert.ToString(limNumber);
        }

        private void button_l_m_Click(object sender, EventArgs e)
        {
            if (limNumber > 0)
            {
                limNumber--; 
                label_lemonade.Text = Convert.ToString(limNumber);
            }
        }

        private void button_h_p_Click(object sender, EventArgs e)
        {
            hotcNumber++;
            label_hotc.Text = Convert.ToString(hotcNumber);
        }

        private void button_h_m_Click(object sender, EventArgs e)
        {
            if (hotcNumber > 0)
            {
                hotcNumber--;
                label_hotc.Text = Convert.ToString(hotcNumber);

            }
        }

        private void button_ch_p_Click(object sender, EventArgs e)
        {
            cheesNumber ++;
            label_cheesec.Text = Convert.ToString(cheesNumber);    
        }

        private void button_ch_m_Click(object sender, EventArgs e)
        {
            if (cheesNumber > 0)
            {
                cheesNumber--;
                label_cheesec.Text = Convert.ToString(cheesNumber);
            }
        }

        private void button_tir_p_Click(object sender, EventArgs e)
        {
            tiramisuNumber ++;
            label_tiramisu.Text = Convert.ToString(tiramisuNumber);
        }

        private void button_tir_m_Click(object sender, EventArgs e)
        {
            if(tiramisuNumber > 0)
            {
                tiramisuNumber--;
                label_tiramisu.Text = Convert.ToString(tiramisuNumber);
            }
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label_tea.Text) > 0)
                listBox1.Items.Add(label_t.Text);

            if(Convert.ToInt32(label_coffee.Text) > 0)
                listBox1.Items.Add(label_c.Text);

            if (Convert.ToInt32 (label_soda.Text) > 0)
                listBox1.Items.Add(label_s.Text);

            if (Convert.ToInt32 (label_lemonade.Text) > 0)
                listBox1.Items.Add(label_l.Text);

            if (Convert.ToInt32(label_hotc.Text) > 0)
                listBox1.Items.Add(label_h.Text);

            if (Convert.ToInt32(label_cheesec.Text) > 0)
                listBox1.Items.Add(label_c.Text);

            if (Convert.ToInt32(label_tiramisu.Text) > 0)
                listBox1.Items.Add(label_tir.Text);

        }

        private void button_total_Click(object sender, EventArgs e)
        {
            int priceTea = Convert.ToInt32(label_tea.Text) * 1;
            int priceCoffee = Convert.ToInt32(label_coffee.Text) * 2;
            int priceLemonade = Convert.ToInt32(label_lemonade.Text) * 2;
            int priceSoda = Convert.ToInt32(label_soda.Text) * 2;
            int priceHotC = Convert.ToInt32(label_hotc.Text) * 3;
            int priceChees = Convert.ToInt32(label_cheesec.Text) * 5;
            int priceTir = Convert.ToInt32(label_tiramisu.Text) * 4;

            int total = priceTea + priceCoffee + priceLemonade + 
                priceSoda + priceHotC + priceChees + priceTir;

            MessageBox.Show("Total " + total);
          
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            teaNumber = 0;
            coffeeNumber = 0;
            limNumber = 0;
            hotcNumber = 0;
            sodaNumber = 0;
            cheesNumber = 0;
            tiramisuNumber = 0;

            label_tea.Text = "0";
            label_coffee.Text = "0";
            label_lemonade.Text = "0";
            label_hotc.Text = "0";
            label_cheesec.Text = "0";
            label_tiramisu.Text = "0";
            label_soda.Text = "0";

            listBox1.Items.Clear();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

   
    }
}
