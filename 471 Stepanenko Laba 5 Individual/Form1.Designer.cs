namespace _471_Stepanenko_Laba_5_Individual
{
    partial class Form1
    {
        string[] tasks = new string[30] {
            "Яка функція коректно порівнює дві подстроки?",
            "Що таке перевантаження методів?",
            "Для чого можна використовувати мову C #?",
            "Які типи змінних існують?",
            "Які цикли існують в мові C #?",
            "Де правильно створений масив?",
            "Де вірно відбувається висновок даних в консоль?",
            "Що робить try-catch?",
            "Де правильно створена змінна?",
            "У чому відмінність між break і continue?",

            "Як правильно вивести текст в консолі на мові С#:",
            "Як правильно зчитати текст з консолі на мові С#:",
            "Як створити змінну:",
            "Як присвоїти значення змінної:",
            "Якого циклу не має в мові C#:",
            "Результат виконання int x = 5 + 1:",
            "Результат виконання string x = 5 + 1:",
            "Як визвати системний звуковий сигнал в мові C#:",
            "Якого типу не має в мові C#:",
            "Якого оператору в мові C# не існує:",

            "Яка функція коректно порівнює дві подстроки?",
            "Що таке перевантаження методів?",
            "Для чого можна використовувати мову C #?",
            "Які типи змінних існують?",
            "Які цикли існують в мові C #?",
            "Де правильно створений масив?",
            "Де вірно відбувається висновок даних в консоль?",
            "Що робить try-catch?",
            "Де правильно створена змінна?",
            "У чому відмінність між break і continue?"
        };
        string[] answers = new string[] {
            "String.Check(\"hi\", \"hello\")",
            "String.Compare(\"hi\", \"hello\")",
            "Передача занадто великого файлу через return",
            "Використання одного імені для різних методів",
            "Передача занадто великого файлу через return",
            "Використання одного імені для різних методів",
            "Для створення лише ігр та програм",
            "Для написання ігор",
            "int, char, bool, string",
            "boolean",
            "for, while",
            "for, while, do while, foreach",
            "int arr = {2, 5};",
            "int[] arr = new int [2] {2, 5};",
            "Console.write(\"Hi\");",
            "Console.WriteLine(\"Hi\");",
            "Працює з класами",
            "Працює з винятками",
            "$x = 10;",
            "char symbol = 'A';",

            "немає відмінностей",
            "Continue пропускає ітерацію, break виходить з циклу",
            "console.log('text')",
            "Console.WriteLine('text')",
            "cin >> a;",
            "string a = Console.ReadLine();",
            "let a;",
            "int a;",
            "a === 3;",
            "a = 3;",
            "for",
            "loop",
            "51",
            "6",
            "6",
            "51",
            "System.Audio();",
            "Console.Beep();",
            "return",
            "begin",

            "String.Check(\"hi\", \"hello\")",
            "String.Compare(\"hi\", \"hello\")",
            "Передача занадто великого файлу через return",
            "Використання одного імені для різних методів",
            "Передача занадто великого файлу через return",
            "Використання одного імені для різних методів",
            "Для створення лише ігр та програм",
            "Для написання ігор",
            "int, char, bool, string",
            "boolean",
            "for, while",
            "for, while, do while, foreach",
            "int arr = {2, 5};",
            "int[] arr = new int [2] {2, 5};",
            "Console.write(\"Hi\");",
            "Console.WriteLine(\"Hi\");",
            "Працює з класами",
            "Працює з винятками",
            "$x = 10;",
            "char symbol = 'A';"
        };

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            int y = 20;
            int index = 1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            for (int i = 0, indexAnswers = 0 ; i < 30; i++, indexAnswers += 2)
            {
                userControlArr[i] = new _471_Stepanenko_Laba_5_Individual.UserControl1();
                userControlArr[i].titleProp = tasks[i];
                userControlArr[i].case1Prop = answers[indexAnswers];
                userControlArr[i].case2Prop = answers[indexAnswers+1];
            }
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Text = "Тест на 30 питань. Індивідуальне завдання до ЛБ 5. Степаненко 471";
            this.label1.Size = new System.Drawing.Size(1000, 50);
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14);
            this.label1.TabIndex = 5;
            //
            // label2
            //
            this.label2.Text = System.String.Format("Ваша оцінка: {0} із {1}", mark, 30);
            this.label2.Size = new System.Drawing.Size(1000, 50);
            this.label2.Location = new System.Drawing.Point(20, 770);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14);
            this.label2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            foreach (UserControl1 item in userControlArr)
            {
                this.panel1.Controls.Add(item);
            }
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 650);
            //this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            //this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.TabIndex = 0;
            //
            // UserControlArr
            //
            foreach (UserControl1 item in userControlArr)
            {
                item.Location = new System.Drawing.Point(20, y);
                item.Name = "userController" + index;
                item.Size = new System.Drawing.Size(1054, 170);
                item.TabIndex = 0;
                y += 190;
                index++;
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private int mark = 0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserControl1[] userControlArr = new UserControl1[30];
    }
}

