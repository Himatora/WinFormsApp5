using WindowsFormsApp5;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        List<Animal> animalsList = new List<Animal>();//������
        Queue<String> animalsQueue = new Queue<String>();//�������
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int catsCount = 0;
            int dogsCount = 0;
            int cowsCount = 0;

            animalsQueue.Clear();
            // ��������� �� ����� ������
            foreach (var animal in this.animalsList)
            {
                // � ������ � ��� ����� ��������,
                // �� ���� ������� ���� Animal
                // ������� ����� ��������� ����� ������ �������� ���������� is
                if (animal is Cat) 
                {
                    catsCount += 1;
                }
                else if (animal is Dog)
                {
                    dogsCount += 1;
                }
                else if (animal is Cow)
                {
                    cowsCount += 1;
                }
                animalsQueue.Enqueue(animal.GetType().ToString().Replace("WindowsFormsApp5.", ""));//�������� � �������
            }

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "���\t������\t������"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", catsCount, dogsCount, cowsCount);
            txtInfo.Text += "\n";
            txtInfo.Text += "�������:\n";
            int count = 1;
            foreach (var animal in animalsQueue)
            {
                txtInfo.Text += count + "." + animal + " ";
                count++;
            }
            if (animalsQueue.Count > 0)//�������� �������� � �������
            {
                picCat.Visible = animalsQueue.Peek() == "Cat";//����� 1 ������� �� ������ �������
                picDog.Visible = animalsQueue.Peek() == "Dog";//����� 1 ������� �� ������ �������
                picCow.Visible = animalsQueue.Peek() == "Cow";//����� 1 ������� �� ������ �������
            }
            else
            {
                picCat.Visible = false;
                picDog.Visible = false;
                picCow.Visible = false;
            }
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.animalsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� �����
                        this.animalsList.Add(Cat.Generate());
                        break;
                    case 1: // ���� 1 �� ������
                        this.animalsList.Add(Dog.Generate());
                        break;
                    case 2: // ���� 2 �� ������
                        this.animalsList.Add(Cow.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // ���� ������ ����, �� ������� ��� ����� � ������ �� �������
            if (this.animalsList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";

                return;
            }

            // ����� ������ ��������
            var animal = this.animalsList[0];
            // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
            // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
            this.animalsList.RemoveAt(0);

            // �� � ������ ��������� ���������� ��� ��������
            txtOut.Text = animal.GetInfo();

            // ������� ���������� � ���������� ������ �� �����
            ShowInfo();
        }
    }
}