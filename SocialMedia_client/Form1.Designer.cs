namespace SocialMedia_Client2;

partial class Form1
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
        button_ActiveUsers = new Button();
        comboBox1 = new ComboBox();
        textBoxKeyword = new TextBox();
        listBoxPosts = new ListBox();
        buttonSearch = new Button();
        buttonApprove = new Button();
        buttonRemove = new Button();
        checkedListBoxUsers = new CheckedListBox();
        buttonSendEmail = new Button();
        SuspendLayout();
        // 
        // button_ActiveUsers
        // 
        button_ActiveUsers.Location = new Point(423, 51);
        button_ActiveUsers.Name = "button_ActiveUsers";
        button_ActiveUsers.Size = new Size(153, 43);
        button_ActiveUsers.TabIndex = 0;
        button_ActiveUsers.Text = "Active Users";
        button_ActiveUsers.UseVisualStyleBackColor = true;
        button_ActiveUsers.Click += button_ActiveUsers_Click;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(166, 57);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(182, 33);
        comboBox1.TabIndex = 1;
        // 
        // textBoxKeyword
        // 
        textBoxKeyword.Location = new Point(166, 332);
        textBoxKeyword.Name = "textBoxKeyword";
        textBoxKeyword.Size = new Size(182, 31);
        textBoxKeyword.TabIndex = 2;
        // 
        // listBoxPosts
        // 
        listBoxPosts.FormattingEnabled = true;
        listBoxPosts.Location = new Point(166, 411);
        listBoxPosts.Name = "listBoxPosts";
        listBoxPosts.Size = new Size(180, 129);
        listBoxPosts.TabIndex = 3;
        // 
        // buttonSearch
        // 
        buttonSearch.Location = new Point(442, 256);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(112, 34);
        buttonSearch.TabIndex = 4;
        buttonSearch.Text = "Search";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // buttonApprove
        // 
        buttonApprove.Location = new Point(442, 318);
        buttonApprove.Name = "buttonApprove";
        buttonApprove.Size = new Size(112, 34);
        buttonApprove.TabIndex = 5;
        buttonApprove.Text = "Approve";
        buttonApprove.UseVisualStyleBackColor = true;
        buttonApprove.Click += buttonApprove_Click;
        // 
        // buttonRemove
        // 
        buttonRemove.Location = new Point(442, 379);
        buttonRemove.Name = "buttonRemove";
        buttonRemove.Size = new Size(112, 34);
        buttonRemove.TabIndex = 6;
        buttonRemove.Text = "Remove";
        buttonRemove.UseVisualStyleBackColor = true;
        buttonRemove.Click += buttonRemove_Click;
        // 
        // checkedListBoxUsers
        // 
        checkedListBoxUsers.FormattingEnabled = true;
        checkedListBoxUsers.Location = new Point(166, 128);
        checkedListBoxUsers.Name = "checkedListBoxUsers";
        checkedListBoxUsers.Size = new Size(180, 144);
        checkedListBoxUsers.TabIndex = 7;
        // 
        // buttonSendEmail
        // 
        buttonSendEmail.Location = new Point(423, 142);
        buttonSendEmail.Name = "buttonSendEmail";
        buttonSendEmail.Size = new Size(153, 43);
        buttonSendEmail.TabIndex = 8;
        buttonSendEmail.Text = "Send Email";
        buttonSendEmail.UseVisualStyleBackColor = true;
        buttonSendEmail.Click += buttonSendEmail_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 579);
        Controls.Add(buttonSendEmail);
        Controls.Add(checkedListBoxUsers);
        Controls.Add(buttonRemove);
        Controls.Add(buttonApprove);
        Controls.Add(buttonSearch);
        Controls.Add(listBoxPosts);
        Controls.Add(textBoxKeyword);
        Controls.Add(comboBox1);
        Controls.Add(button_ActiveUsers);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button_ActiveUsers;
    private ComboBox comboBox1;
    private TextBox textBoxKeyword;
    private ListBox listBoxPosts;
    private Button buttonSearch;
    private Button buttonApprove;
    private Button buttonRemove;
    private CheckedListBox checkedListBoxUsers;
    private Button buttonSendEmail;
}
