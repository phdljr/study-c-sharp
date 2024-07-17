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
                Thread.Sleep(3000);  // 3초 대기를 시뮬레이션
                label1.Text = "비동기 작업 완료";
            });
            this.Invoke(() =>
            {
                Thread.Sleep(3000);  // 3초 대기를 시뮬레이션
                label1.Text = "비동기 작업2 완료";
            });
            Thread.Sleep(7000);  // 7초 대기를 시뮬레이션
            this.Invoke(() =>
            {
                label1.Text = "완료";
            });
        }
    }
}
