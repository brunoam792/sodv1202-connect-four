namespace ConnectFourBR
{
    partial class GameForm
    {
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
            tableLayoutPanelBoardGame = new TableLayoutPanel();
            tableLayoutPanelScore = new TableLayoutPanel();
            tableLayoutPanelScorePlayer2 = new TableLayoutPanel();
            textBox3 = new TextBox();
            tableLayoutPanelScorePlayer1 = new TableLayoutPanel();
            textBox1 = new TextBox();
            tableLayoutPanelScore.SuspendLayout();
            tableLayoutPanelScorePlayer2.SuspendLayout();
            tableLayoutPanelScorePlayer1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelBoardGame
            // 
            tableLayoutPanelBoardGame.ColumnCount = 7;
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanelBoardGame.Location = new Point(4, 73);
            tableLayoutPanelBoardGame.Name = "tableLayoutPanelBoardGame";
            tableLayoutPanelBoardGame.RowCount = 6;
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanelBoardGame.Size = new Size(792, 374);
            tableLayoutPanelBoardGame.TabIndex = 0;
            // 
            // tableLayoutPanelScore
            // 
            tableLayoutPanelScore.ColumnCount = 2;
            tableLayoutPanelScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelScore.Controls.Add(tableLayoutPanelScorePlayer2, 1, 0);
            tableLayoutPanelScore.Controls.Add(tableLayoutPanelScorePlayer1, 0, 0);
            tableLayoutPanelScore.Location = new Point(4, 2);
            tableLayoutPanelScore.Name = "tableLayoutPanelScore";
            tableLayoutPanelScore.RowCount = 1;
            tableLayoutPanelScore.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelScore.Size = new Size(792, 65);
            tableLayoutPanelScore.TabIndex = 1;
            // 
            // tableLayoutPanelScorePlayer2
            // 
            tableLayoutPanelScorePlayer2.ColumnCount = 1;
            tableLayoutPanelScorePlayer2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelScorePlayer2.Controls.Add(textBox3, 0, 0);
            tableLayoutPanelScorePlayer2.Location = new Point(399, 3);
            tableLayoutPanelScorePlayer2.Name = "tableLayoutPanelScorePlayer2";
            tableLayoutPanelScorePlayer2.RowCount = 1;
            tableLayoutPanelScorePlayer2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelScorePlayer2.Size = new Size(390, 59);
            tableLayoutPanelScorePlayer2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(384, 50);
            textBox3.TabIndex = 2;
            textBox3.Text = "Player 2";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanelScorePlayer1
            // 
            tableLayoutPanelScorePlayer1.ColumnCount = 1;
            tableLayoutPanelScorePlayer1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.88976F));
            tableLayoutPanelScorePlayer1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanelScorePlayer1.Location = new Point(3, 3);
            tableLayoutPanelScorePlayer1.Name = "tableLayoutPanelScorePlayer1";
            tableLayoutPanelScorePlayer1.RowCount = 1;
            tableLayoutPanelScorePlayer1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelScorePlayer1.Size = new Size(390, 59);
            tableLayoutPanelScorePlayer1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "Player 1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanelScore);
            Controls.Add(tableLayoutPanelBoardGame);
            Name = "GameForm";
            Text = "ConnectFourBR";
            tableLayoutPanelScore.ResumeLayout(false);
            tableLayoutPanelScorePlayer2.ResumeLayout(false);
            tableLayoutPanelScorePlayer2.PerformLayout();
            tableLayoutPanelScorePlayer1.ResumeLayout(false);
            tableLayoutPanelScorePlayer1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelBoardGame;
        private TableLayoutPanel tableLayoutPanelScore;
        private TableLayoutPanel tableLayoutPanelScorePlayer2;
        private TableLayoutPanel tableLayoutPanelScorePlayer1;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}

/*
public partial class GameForm : Form
{
    private GameController gameController;

    public GameForm()
    {
        InitializeComponent();
        gameController = new GameController(this);
    }

    private void btnMakeMove_Click(object sender, EventArgs e)
    {
        int column = GetSelectedColumn();
        gameController.MakeMove(column);
        gameController.UpdateBoard();
    }

    public void UpdateBoard(int[,] board)
    {
        // Lógica para atualizar o tabuleiro na interface gráfica
    }

    private int GetSelectedColumn()
    {
        // Lógica para obter a coluna selecionada pelo usuário
    }
}
*/