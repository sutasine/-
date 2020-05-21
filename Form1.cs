using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double money,family,pragun,house,shopping,donate,pay,plus,sumofdonate,plusplus,sum;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        double tmp,abc,xyz;
        private void button1_Click(object sender, EventArgs e)
        {
            money = Convert.ToDouble(textBox1.Text)*12 ; //เงินเดือนต่อปี
            pay = money * 0.5; ///เงินเดือนหักออก 50% เป็นค่าใช้จ่ายแต่ไม่เกิน 100000
            if (pay > 100000)
            {
                pay = 100000;
            }
            
            
            //กลุ่มครอบครัว 
            family = 0;
            double belly = Convert.ToDouble(textBox2.Text); //ฝากครรภ์
            double disabled = Convert.ToDouble(textBox3.Text)*60000; //พิการ
            double child1 = Convert.ToDouble(numericUpDown1.Value)*30000; //ลูกเกิดก่อน61
            double child2 = Convert.ToDouble(numericUpDown2.Value); //ลูกเกิดหลัง61
            if (radioButton3.Checked)
            {
                family = family + 120000;
            }
            else
            {
                family = family + 60000;
            }
            if (child2 > 0)
            {
                if (child1 == 0)
                {
                    family = family + ((child2-1) * 60000) + 30000;
                }
                else
                {
                    family = family + (child2 * 60000); //ลูกคนที่สองเกิดหลัง61
                }
            }
            else
            {
                family = family + 0;
            }
            if (checkBox2.Checked)
            {
                family = family + 30000; //ค่าเลี้ยงดู
            }
            if (checkBox3.Checked)
            {
                family = family + 30000;
            }
            if (checkBox4.Checked)
            {
                family = family + 30000;
            }
            if (checkBox5.Checked)
            {
                family = family + 30000;
            }
            if (Convert.ToDouble(textBox2.Text)>60000) //ค่าคลอดบุตร
            {
                textBox2.Text = "60000";
                belly = 60000;
            }
            family = family + belly + child1 + disabled;
           
            //กลุ่มที่สองประกัน
            //ประกันสังคม
            if (Convert.ToDouble(social.Text) > 9000) 
            {
                social.Text = "9000";
                pragun = pragun + 9000;
            }
            else
            {
                pragun = pragun + Convert.ToDouble(social.Text);
            }
            //ประกันชีวิต
            if (Convert.ToDouble(life.Text) > 100000)
            {
                life.Text = "100000";
                tmp = tmp + 100000;
            }
            else
            {
                tmp = tmp + Convert.ToDouble(life.Text);
            }
            //ประกันสุขภาพ
            if (Convert.ToDouble(health.Text) > 15000)
            {
                health.Text = "15000";
                tmp = tmp + 15000;
            }
            else
            {
                tmp = tmp + Convert.ToDouble(health.Text);
            }
            //เช็คประกันชีวิต + สุขภาพไม่เกิน 100000
            if (tmp > 100000)
            {
                tmp = 100000;
            }
            //ประกันพ่อแม่
            if (Convert.ToDouble(parents.Text) > 15000)
            {
                parents.Text = "15000";
                pragun = pragun + 15000;
            }
            else
            {
                pragun = pragun + Convert.ToDouble(parents.Text);
            }
            //ประกันคู่สมรส
            if (Convert.ToDouble(couple.Text) > 10000)
            {
                couple.Text = "10000";
                pragun = pragun + 10000;
            }
            else
            {
                pragun = pragun + Convert.ToDouble(couple.Text);
            }
            //เบี้ยเลี้ยงชีพ
            if (Convert.ToDouble(chip.Text) > 490000)
            {
                chip.Text = "490000";
                abc = abc + 490000;
            }
            else if (Convert.ToDouble(chip.Text) > money * 0.15)
            {
                chip.Text = (money * 0.15).ToString();
                abc = abc + (money*0.15);
            }
            else
            {
                abc = abc + Convert.ToDouble(chip.Text);
            }
            //กบข.
            if (Convert.ToDouble(teacher.Text) > 50000) //ไม่เกินห้าแสนไม่เกิน15%ของเงินได้
            {
                teacher.Text = "50000";
                abc = abc + 50000;
            }
            else if (Convert.ToDouble(teacher.Text) > money * 0.15)
            {
                teacher.Text = (money * 0.15).ToString();
                abc = abc + (money * 0.15);
            }
            else
            {
                abc = abc + Convert.ToDouble(teacher.Text);
            }
            //กอช.
            if (Convert.ToDouble(koch.Text) > 10000)
            {
                koch.Text = "10000";
                pragun = pragun + 10000;
            }
            else
            {
                pragun = pragun + Convert.ToDouble(koch.Text);
            }
            //บำนาญ
            if (Convert.ToDouble(pension.Text) > 200000) //ไม่เกินสองแสนไม่เกิน15%ของเงินได้
            {
                pension.Text = "200000";
                abc = abc + 200000;
            }
            else if (Convert.ToDouble(pension.Text) > money * 0.15)
            {
                pension.Text = (money * 0.15).ToString();
                abc = abc + (money * 0.15);
            }
            else
            {
                abc = abc + Convert.ToDouble(pension.Text);
            }
            //ltf
            if (Convert.ToDouble(ltf.Text) > 500000)
            {
                ltf.Text = "500000";
                pragun = pragun + 500000;
            }
            else if (Convert.ToDouble(ltf.Text) > money * 0.15)
            {
                ltf.Text = (money * 0.15).ToString();
                pragun = pragun + (money * 0.15);
            }
            else
            {
                pragun = pragun + Convert.ToDouble(ltf.Text);
            }
            //rmf
            if (Convert.ToDouble(rmf.Text) > 500000)
            {
                rmf.Text = "500000";
                abc = abc + 500000;
            }
            else if (Convert.ToDouble(rmf.Text) > money * 0.15)
            {
               rmf.Text = (money * 0.15).ToString();
                abc = abc + (money * 0.15);
            }
            else
            {
                abc = abc + Convert.ToDouble(rmf.Text);
            }
            //เช็คบำนาญ+กองทุนเลี้ยงชีพ+กบข.+rmf ไม่เกิน500000
            if (abc > 500000)
            {
                abc = 500000;
            }
            pragun = pragun + abc + tmp;

            //กลุ่มอสัง
            house = 0;
            int homee = Convert.ToInt32(home.Text);
            if (home.Text == "")
            {
                home.Text = "0";
            }
            double house58 = (Convert.ToInt32(first1.Text)) * 0.04; 
            if (first1.Text == "")
            {
                first1.Text = "0";
            }
            double house62 = (Convert.ToInt32(first.Text)) * 0.04;
            if (first.Text == "")
            {
                first.Text = "0";
            }
            house = homee + house58 + house62;

            //ช้อปจ้า
            //ช้อปอันแรก
            if (Convert.ToDouble(shop.Text) > 15000)
            {
                shop.Text = "15000";
                shopping = shopping + 15000;
            }
            else
            {
                shopping = shopping + Convert.ToDouble(shop.Text);
            }
            //ท่องเที่ยวเมืองหลัก
            if (Convert.ToDouble(main.Text) > 15000)
            {
                main.Text = "15000";
                xyz = xyz + 15000;
            }
            else
            {
                xyz = xyz + Convert.ToDouble(main.Text);
            }
            //ท่องเที่ยวเมืองรอง
            if (Convert.ToDouble(secondary.Text) > 20000)
            {
                secondary.Text = "20000";
                xyz = xyz + 20000;
            }
            else
            {
                xyz = xyz + Convert.ToDouble(secondary.Text);
            }
            //ภัยธรรมชาติบ้าน
            if (Convert.ToDouble(bann.Text) > 100000)
            {
                bann.Text = "100000";
                shopping = shopping + 100000;
            }
            else
            {
                shopping = shopping + Convert.ToDouble(bann.Text);
            }
            //ภัยธรรมชาติรถ
            if (Convert.ToDouble(rott.Text) > 30000)
            {
                rott.Text = "30000";
                shopping = shopping + 30000;
            }
            else
            {
                shopping = shopping + Convert.ToDouble(rott.Text);
            }
            //เช็คเที่ยวไม่เกิน20000
            if (xyz > 20000)
            {
                xyz = 20000;
            }
            shopping = shopping + xyz;

            //กลุ่มบริจาค
            donate = 0;
            plus = family + pragun + house + shopping;
            sumofdonate = money - pay - plus;
            double borijak, borijaktammada, borijakkk = 0;
            double tenper = sumofdonate * 0.1;
            double tennper = (sumofdonate * 0.1) / 2; //ไม่เกิน10%ของเงินได้
            if (sport.Text == "")
            {
                sport.Text = "0";
            }
            
            borijak = Convert.ToInt32(sport.Text) * 2; //บริจาคการศึกษากีฬาลดหย่อน2เท่า
            if (borijak > tenper)
            {
                if (tennper < 0 )
                {
                    tennper = 0;
                }
                borijak = tenper;
                sport.Text = tennper.ToString();
            }
            if (normal.Text == "")
            {
                normal.Text = "0";
            }
            borijaktammada = Convert.ToDouble(normal.Text); //บริจาคธรรมดา
            plusplus = money - pay - plus - borijak;
            double tenperten = plusplus * 0.1;
            if (borijaktammada > tenperten)
            {
                if (tenperten < 0)
                {
                    tenperten = 0;
                }
                borijaktammada = tenperten;
                normal.Text = tenperten.ToString();
            }
            if (politics.Text == "")
            {
                politics.Text = "0";
            }
            borijakkk = Convert.ToDouble(politics.Text); //บริจาครัฐบาลนักการเมือง
            if (borijakkk > 10000)
            {
                borijakkk = 10000;
                politics.Text = borijakkk.ToString();
            }
            ///บริจาคเงินทั่วไป + บริจาครัฐบาล
            donate = borijaktammada + borijak + borijakkk;
            sum = money - pay - donate - plus;

            //คำนวนขั้นบันได
           
            if (sum < 0)
            {
                sum = 0;
            }
            textBox5.Text = sum.ToString();
            if (sum >= 0 && sum <= 150000) //ไม่ต้องเสีย
            {
                sum = 0;
            }
            else if (sum > 150000 && sum <= 300000) //ต้องเสีย5%
            {
                sum = (sum - 150000) * 0.05;
            }
            else if (sum > 300000 && sum <= 500000) //ต้องเสีย10%
            {
                sum = ((sum - 300000) * 0.1) + 7500;
            }
            else if (sum > 500000 && sum <= 7500000) //ต้องเสีย15%
            {
                sum = ((sum - 500000) * 0.15) + 27500;
            }
            else if (sum > 750000 && sum <= 1000000) //ต้องเสีย20% 
            {
                sum = ((sum - 750000) * 0.2) + 65000;
            }
            else if (sum > 1000000 && sum <= 2000000) //ต้องเสีย25% 
            {
                sum = ((sum - 1000000) * 0.25) + 115000;
            }
            else if (sum > 2000000 && sum <= 5000000) //ต้องเสีย30% 
            {
                sum = ((sum - 2000000) * 0.3) + 365000;
            }
            else if (sum > 5000000) //ต้องเสีย35% 
            {
                sum = ((sum - 5000000) * 0.35) + 1265000;
            }
            textBox4.Text = sum.ToString();
        }


    }
}
