namespace WinFormsApp_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // byte长度在
            byte b = 255;

            // short 数值类型在-32768 ---- 32767
            short min = -32768;
            short maxLength = 32767;

            // int的范围-2,147,483,648 到 2,147,483,647
            int i = -214748364;
            int i2 = 2147483647;

            // long的取值范围 -923,372,036,854,775,808 到 9,223,372,036,854,775,807

            // float取值范围
            // test();
            // nullTest();
            test2();
            // strTest();
            bool b2 = 1 == 1;
            bool b3 = 2 == 2;

        }

        private void load()
        {
            int i = 0;
            long l = 0;
        }

        private void test()
        {
            float f = 1.1F;
            int i = 2;
            MessageBox.Show(f.ToString());
            f = i;
            MessageBox.Show(f.ToString());

            double d = 1.1;

            d = f;
            d = i;

            // 	128 位精确的十进制值，28-29 有效位数 (-7.9 x 1028 到 7.9 x 1028) / 100 到 28
            decimal dec = 1.1M;

            dec = i;
            // 浮点型之间的转换只有float转换为double一种
            // d = dec;
            // dec = d;


            bool boo = false;
            int wi = 0;
            while (boo)
            {

                wi++;
                if (wi == 100)
                {

                    break;
                }

                boo = false;
            }
        }

        private void strTest()
        {
            // 字符串
            String st = "Hello World!";
            MessageBox.Show(st);

            // 字符
            char c = 'a';
            MessageBox.Show(c.ToString());
        }

        private void nullTest()
        {
            String s = null;
            s = null;
            MessageBox.Show(s);
            s = "";
            MessageBox.Show(s);
        }

        private void test2()
        {

            int i = 1110 | 110;
            MessageBox.Show(i.ToString());
        }
    }
}