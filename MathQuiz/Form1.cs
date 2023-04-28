namespace MathQuiz
{
  public partial class Form1 : Form
  {

    Random randomizer = new Random();

    int addend1;
    int addend2;

    int minuend;
    int subtrahend;

    int multiplicand;
    int multiplier;

    int dividend;
    int divisor;

    int timeLeft;


    public void StartTheQuiz()
    {
      this.addend1 = this.randomizer.Next(51);
      this.addend2 = this.randomizer.Next(51);

      // Place the values of the addends into the
      // label controls on the form.
      this.plusLeftLabel.Text = this.addend1.ToString();
      this.plusRightLabel.Text = this.addend2.ToString();

      // Initialize the value of the sum numeric control
      // to zero.
      this.sum.Value = 0;

      this.minuend = this.randomizer.Next(1, 101);
      this.subtrahend = this.randomizer.Next(1, this.minuend);
      this.minusLeftLabel.Text = this.minuend.ToString();
      this.minusRightLabel.Text = this.subtrahend.ToString();
      this.difference.Value = 0;

      this.multiplicand = this.randomizer.Next(2, 11);
      this.multiplier = this.randomizer.Next(2, 11);
      this.timesLeftLabel.Text = this.multiplicand.ToString();
      this.timesRightLabel.Text = this.multiplier.ToString();
      this.product.Value = 0;

      this.divisor = this.randomizer.Next(2, 11);
      int temporaryQuotient = this.randomizer.Next(2, 11);
      this.dividend = this.divisor * temporaryQuotient;
      this.dividedLeftLabel.Text = this.dividend.ToString();
      this.dividedRightLabel.Text = this.divisor.ToString();
      this.quotient.Value = 0;

      // Start the timer
      this.timeLeft = 30;
      this.timeLabel.Text = "30 seconds";
      this.timer1.Start();
    }

    private bool CheckTheAnswer()
    {
      if ((this.addend1 + this.addend2 == this.sum.Value)
        && (this.minuend - this.subtrahend == this.difference.Value)
        && (this.multiplicand * this.multiplier == this.product.Value)
        && (this.dividend / this.divisor == this.quotient.Value))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public Form1()
    {
      this.InitializeComponent();
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      this.StartTheQuiz();
      this.startButton.Enabled = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this.CheckTheAnswer())
      {
        // If CheckTheAnswer() returns true, then the user
        // got the answer right.  Stop the timer
        // and show a MessageBox
        this.timer1.Stop();
        MessageBox.Show("You got all the answers right!", "Congratulations!");
        this.timeLabel.BackColor = Color.Transparent;
        this.startButton.Enabled = true;
      }
      else if (this.timeLeft > 0)
      {
        // If CheckTheAnswer() returns false, keep counting
        // down.  Decrease the time and update the time label
        this.timeLeft--;
        this.timeLabel.Text = this.timeLeft + " seconds";
        if (this.timeLeft <= 5)
        {
          this.timeLabel.BackColor = Color.Red;
        }
      }
      else
      {
        // If the user ran out of time, stop the timer,
        // show a MessageBox, and fill in the answers.
        this.timer1.Stop();
        this.timeLabel.Text = "Time's up!";
        this.timeLabel.BackColor = Color.Transparent;
        MessageBox.Show("You didn't finish in time.", "Sorry!");
        this.sum.Value = this.addend1 + this.addend2;
        this.difference.Value = this.minuend - this.subtrahend;
        this.product.Value = this.multiplicand * this.multiplier;
        this.quotient.Value = this.dividend / this.divisor;
        this.startButton.Enabled = true;
      }
    }

    private void answer_Enter(object sender, EventArgs e)
    {
      // Select the whole answer in the Numeric Control
      NumericUpDown answerBox = sender as NumericUpDown;

      if (answerBox != null)
      {
        int lengthOfAnswer = answerBox.Value.ToString().Length;
        answerBox.Select(0, lengthOfAnswer);
      }
    }
  }
}