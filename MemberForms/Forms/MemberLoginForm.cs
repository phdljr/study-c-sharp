namespace MemberForms
{
    public partial class MemberLoginForm : Form
    {
        public MemberLoginForm()
        {
            InitializeComponent();
            Task.Run(DoBackgroundWorkAsync);
        }

        private void DoBackgroundWorkAsync()
        {
            Thread.Sleep(1000);
            this.Invoke(() =>
            {
                Thread.Sleep(3000);  // 3�� ��⸦ �ùķ��̼�
                label1.Text = "�񵿱� �۾� �Ϸ�";
            });
            this.Invoke(() =>
            {
                Thread.Sleep(3000);  // 3�� ��⸦ �ùķ��̼�
                label1.Text = "�񵿱� �۾�2 �Ϸ�";
            });
            Thread.Sleep(7000);  // 7�� ��⸦ �ùķ��̼�
            this.Invoke(() =>
            {
                label1.Text = "�Ϸ�";
            });
        }
    }
}
