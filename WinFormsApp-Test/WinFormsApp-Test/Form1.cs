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

            // byte������
            byte b = 255;

            // short ��ֵ������-32768 ---- 32767
            short min = -32768;
            short maxLength = 32767;

            // int�ķ�Χ-2,147,483,648 �� 2,147,483,647
            int i = -214748364;
            int i2 = 2147483647;

            // long��ȡֵ��Χ -923,372,036,854,775,808 �� 9,223,372,036,854,775,807

            // floatȡֵ��Χ
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

            // 	128 λ��ȷ��ʮ����ֵ��28-29 ��Чλ�� (-7.9 x 1028 �� 7.9 x 1028) / 100 �� 28
            decimal dec = 1.1M;

            dec = i;
            // ������֮���ת��ֻ��floatת��Ϊdoubleһ��
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
            // �ַ���
            String st = "Hello World!";
            MessageBox.Show(st);

            // �ַ�
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