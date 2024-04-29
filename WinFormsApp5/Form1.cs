using WindowsFormsApp5;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        List<Animal> animalsList = new List<Animal>();//список
        Queue<String> animalsQueue = new Queue<String>();//очередь
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int catsCount = 0;
            int dogsCount = 0;
            int cowsCount = 0;

            animalsQueue.Clear();
            // пройдемся по всему списку
            foreach (var animal in this.animalsList)
            {
                // в списке у нас лежат животные,
                // то есть объекты типа Animal
                // поэтому чтобы проверить какое именно животное используем is
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
                animalsQueue.Enqueue(animal.GetType().ToString().Replace("WindowsFormsApp5.", ""));//добавить в очередь
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Кот\tСобака\tКорова"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", catsCount, dogsCount, cowsCount);
            txtInfo.Text += "\n";
            txtInfo.Text += "Очередь:\n";
            int count = 1;
            foreach (var animal in animalsQueue)
            {
                txtInfo.Text += count + "." + animal + " ";
                count++;
            }
            if (animalsQueue.Count > 0)//картинки животных в очереди
            {
                picCat.Visible = animalsQueue.Peek() == "Cat";//берем 1 элемент из начала очереди
                picDog.Visible = animalsQueue.Peek() == "Dog";//берем 1 элемент из начала очереди
                picCow.Visible = animalsQueue.Peek() == "Cow";//берем 1 элемент из начала очереди
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
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то кошка
                        this.animalsList.Add(Cat.Generate());
                        break;
                    case 1: // если 1 то собака
                        this.animalsList.Add(Dog.Generate());
                        break;
                    case 2: // если 2 то корова
                        this.animalsList.Add(Cow.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.animalsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";

                return;
            }

            // взяли первое животное
            var animal = this.animalsList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.animalsList.RemoveAt(0);

            // ну а теперь предложим покупателю его животное
            txtOut.Text = animal.GetInfo();

            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}