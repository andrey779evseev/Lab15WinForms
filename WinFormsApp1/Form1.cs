namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        (textBox2.Text, textBox1.Text) = (textBox1.Text, textBox2.Text);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Clear();
        textBox2.Clear();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var str = "";
        if(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) == 180)
        {
            str = "эти углы €вл€ютс€ углами треугольника";
            if (Convert.ToInt32(textBox3.Text) > 90 || Convert.ToInt32(textBox4.Text) > 90 || Convert.ToInt32(textBox5.Text) > 90)
                str += " и этот треугольник €вл€етс€ тупоугольным";
            else
                str += " и этот треугольник не €вл€етс€ тупоугольным";
        }
        else
            str = "эти углы не €вл€ютс€ углами треугольника";
        label3.Text = str;
    }

    private void button4_Click(object sender, EventArgs e)
    {
        var n = Convert.ToInt32(textBox6.Text);
        var str = "";
        var count = 0;
        for (var i = 100; i < n && i < 1000; i++)
        {
            if(i.ToString().Distinct().Count() != i.ToString().Length)
            {
                count++;
                str += i + ",  ";
            }
        }
        str += "\n кол-во: " + count;
        label5.Text = str;
    }

    private void button5_Click(object sender, EventArgs e)
    {
        var width = Convert.ToDouble(textBox7.Text);
        var height = Convert.ToDouble(textBox8.Text);
        var length = Convert.ToDouble(textBox9.Text);
        var v = width * height * length;
        var s = 2 * (width * height + height * length + width * length);
        if(checkBox1.Checked)
        {
            v = Math.Round(v);
            s = Math.Round(s);
        }
        label7.Text = "плошадь поверхности : " + s + " обьем : " + v;
    }

    private void button6_Click(object sender, EventArgs e)
    {
        var course = Convert.ToDouble(textBox10.Text);
        var arr = new List<dynamic>();
        for (var i = 1; i < 21; i++)
        {
            arr.Add(new { 
                USD = i,
                RUB = i * course
            });
        }
        dataGridView1.DataSource = arr;
    }
}