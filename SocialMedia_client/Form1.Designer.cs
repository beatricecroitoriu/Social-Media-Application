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
        Email = new TabControl();
        tabPagePosts = new TabPage();
        buttonViewPublishedPosts = new Button();
        buttonRemovePost = new Button();
        buttonApprove = new Button();
        buttonSearch = new Button();
        listBoxPosts = new ListBox();
        textBoxKeyword = new TextBox();
        comboBoxActiveUsers = new ComboBox();
        button_ActiveUsers = new Button();
        tabPageUsers = new TabPage();
        label5 = new Label();
        textBoxUserStatus = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label1 = new Label();
        textBoxUserEmail = new TextBox();
        textBoxUserName = new TextBox();
        textBoxKeywordUser = new TextBox();
        buttonUpdateUser = new Button();
        buttonRemoveUser = new Button();
        buttonSearchUsers = new Button();
        listBoxUsers = new ListBox();
        tabPageComments = new TabPage();
        label2 = new Label();
        buttonRemoveComment = new Button();
        buttonSearchComment = new Button();
        listBoxComments = new ListBox();
        textBoxKeywordComment = new TextBox();
        tabPageEmail = new TabPage();
        textBoxSubjectEmail = new TextBox();
        textBoxBodyEmail = new TextBox();
        buttonSendEmail = new Button();
        checkedListBoxUsers = new CheckedListBox();
        Email.SuspendLayout();
        tabPagePosts.SuspendLayout();
        tabPageUsers.SuspendLayout();
        tabPageComments.SuspendLayout();
        tabPageEmail.SuspendLayout();
        SuspendLayout();
        // 
        // Email
        // 
        Email.Controls.Add(tabPagePosts);
        Email.Controls.Add(tabPageUsers);
        Email.Controls.Add(tabPageComments);
        Email.Controls.Add(tabPageEmail);
        Email.Location = new Point(12, 12);
        Email.Name = "Email";
        Email.SelectedIndex = 0;
        Email.Size = new Size(1061, 595);
        Email.TabIndex = 12;
        // 
        // tabPagePosts
        // 
        tabPagePosts.Controls.Add(buttonViewPublishedPosts);
        tabPagePosts.Controls.Add(buttonRemovePost);
        tabPagePosts.Controls.Add(buttonApprove);
        tabPagePosts.Controls.Add(buttonSearch);
        tabPagePosts.Controls.Add(listBoxPosts);
        tabPagePosts.Controls.Add(textBoxKeyword);
        tabPagePosts.Controls.Add(comboBoxActiveUsers);
        tabPagePosts.Controls.Add(button_ActiveUsers);
        tabPagePosts.Location = new Point(4, 34);
        tabPagePosts.Name = "tabPagePosts";
        tabPagePosts.Padding = new Padding(3);
        tabPagePosts.Size = new Size(1053, 557);
        tabPagePosts.TabIndex = 0;
        tabPagePosts.Text = "Posts";
        tabPagePosts.UseVisualStyleBackColor = true;
        // 
        // buttonViewPublishedPosts
        // 
        buttonViewPublishedPosts.Location = new Point(585, 88);
        buttonViewPublishedPosts.Name = "buttonViewPublishedPosts";
        buttonViewPublishedPosts.Size = new Size(153, 43);
        buttonViewPublishedPosts.TabIndex = 17;
        buttonViewPublishedPosts.Text = "Published Posts";
        buttonViewPublishedPosts.UseVisualStyleBackColor = true;
        buttonViewPublishedPosts.Click += buttonViewPublishedPosts_Click;
        // 
        // buttonRemovePost
        // 
        buttonRemovePost.Location = new Point(597, 275);
        buttonRemovePost.Name = "buttonRemovePost";
        buttonRemovePost.Size = new Size(112, 34);
        buttonRemovePost.TabIndex = 16;
        buttonRemovePost.Text = "Remove";
        buttonRemovePost.UseVisualStyleBackColor = true;
        buttonRemovePost.Click += buttonRemove_Click;
        // 
        // buttonApprove
        // 
        buttonApprove.Location = new Point(597, 210);
        buttonApprove.Name = "buttonApprove";
        buttonApprove.Size = new Size(112, 34);
        buttonApprove.TabIndex = 15;
        buttonApprove.Text = "Approve ";
        buttonApprove.UseVisualStyleBackColor = true;
        buttonApprove.Click += buttonApprove_Click;
        // 
        // buttonSearch
        // 
        buttonSearch.Location = new Point(772, 146);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(112, 34);
        buttonSearch.TabIndex = 14;
        buttonSearch.Text = "Search";
        buttonSearch.UseVisualStyleBackColor = true;
        buttonSearch.Click += buttonSearch_Click;
        // 
        // listBoxPosts
        // 
        listBoxPosts.FormattingEnabled = true;
        listBoxPosts.Location = new Point(222, 88);
        listBoxPosts.Name = "listBoxPosts";
        listBoxPosts.Size = new Size(307, 454);
        listBoxPosts.TabIndex = 13;
        // 
        // textBoxKeyword
        // 
        textBoxKeyword.Location = new Point(563, 149);
        textBoxKeyword.Name = "textBoxKeyword";
        textBoxKeyword.Size = new Size(203, 31);
        textBoxKeyword.TabIndex = 12;
        // 
        // comboBoxActiveUsers
        // 
        comboBoxActiveUsers.FormattingEnabled = true;
        comboBoxActiveUsers.Location = new Point(222, 28);
        comboBoxActiveUsers.Name = "comboBoxActiveUsers";
        comboBoxActiveUsers.Size = new Size(307, 33);
        comboBoxActiveUsers.TabIndex = 11;
        // 
        // button_ActiveUsers
        // 
        button_ActiveUsers.Location = new Point(585, 28);
        button_ActiveUsers.Name = "button_ActiveUsers";
        button_ActiveUsers.Size = new Size(153, 43);
        button_ActiveUsers.TabIndex = 10;
        button_ActiveUsers.Text = "Active Users";
        button_ActiveUsers.UseVisualStyleBackColor = true;
        button_ActiveUsers.Click += button_ActiveUsers_Click;
        // 
        // tabPageUsers
        // 
        tabPageUsers.Controls.Add(label5);
        tabPageUsers.Controls.Add(textBoxUserStatus);
        tabPageUsers.Controls.Add(label4);
        tabPageUsers.Controls.Add(label3);
        tabPageUsers.Controls.Add(label1);
        tabPageUsers.Controls.Add(textBoxUserEmail);
        tabPageUsers.Controls.Add(textBoxUserName);
        tabPageUsers.Controls.Add(textBoxKeywordUser);
        tabPageUsers.Controls.Add(buttonUpdateUser);
        tabPageUsers.Controls.Add(buttonRemoveUser);
        tabPageUsers.Controls.Add(buttonSearchUsers);
        tabPageUsers.Controls.Add(listBoxUsers);
        tabPageUsers.Location = new Point(4, 34);
        tabPageUsers.Name = "tabPageUsers";
        tabPageUsers.Padding = new Padding(3);
        tabPageUsers.Size = new Size(1053, 557);
        tabPageUsers.TabIndex = 1;
        tabPageUsers.Text = "Users";
        tabPageUsers.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(716, 260);
        label5.Name = "label5";
        label5.Size = new Size(59, 25);
        label5.TabIndex = 33;
        label5.Text = "status";
        // 
        // textBoxUserStatus
        // 
        textBoxUserStatus.Location = new Point(716, 288);
        textBoxUserStatus.Name = "textBoxUserStatus";
        textBoxUserStatus.ReadOnly = true;
        textBoxUserStatus.Size = new Size(239, 31);
        textBoxUserStatus.TabIndex = 32;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(716, 190);
        label4.Name = "label4";
        label4.Size = new Size(54, 25);
        label4.TabIndex = 31;
        label4.Text = "email";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(716, 121);
        label3.Name = "label3";
        label3.Size = new Size(56, 25);
        label3.TabIndex = 30;
        label3.Text = "name";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(536, 43);
        label1.Name = "label1";
        label1.Size = new Size(80, 25);
        label1.TabIndex = 29;
        label1.Text = "keyword";
        // 
        // textBoxUserEmail
        // 
        textBoxUserEmail.Location = new Point(716, 217);
        textBoxUserEmail.Name = "textBoxUserEmail";
        textBoxUserEmail.Size = new Size(239, 31);
        textBoxUserEmail.TabIndex = 28;
        // 
        // textBoxUserName
        // 
        textBoxUserName.Location = new Point(716, 149);
        textBoxUserName.Name = "textBoxUserName";
        textBoxUserName.Size = new Size(239, 31);
        textBoxUserName.TabIndex = 27;
        // 
        // textBoxKeywordUser
        // 
        textBoxKeywordUser.Location = new Point(536, 71);
        textBoxKeywordUser.Name = "textBoxKeywordUser";
        textBoxKeywordUser.Size = new Size(203, 31);
        textBoxKeywordUser.TabIndex = 26;
        // 
        // buttonUpdateUser
        // 
        buttonUpdateUser.Location = new Point(843, 350);
        buttonUpdateUser.Name = "buttonUpdateUser";
        buttonUpdateUser.Size = new Size(112, 34);
        buttonUpdateUser.TabIndex = 25;
        buttonUpdateUser.Text = "Update";
        buttonUpdateUser.UseVisualStyleBackColor = true;
        buttonUpdateUser.Click += buttonUpdateUser_Click;
        // 
        // buttonRemoveUser
        // 
        buttonRemoveUser.Location = new Point(553, 181);
        buttonRemoveUser.Name = "buttonRemoveUser";
        buttonRemoveUser.Size = new Size(112, 34);
        buttonRemoveUser.TabIndex = 24;
        buttonRemoveUser.Text = "Remove";
        buttonRemoveUser.UseVisualStyleBackColor = true;
        buttonRemoveUser.Click += buttonRemoveUser_Click;
        // 
        // buttonSearchUsers
        // 
        buttonSearchUsers.Location = new Point(762, 71);
        buttonSearchUsers.Name = "buttonSearchUsers";
        buttonSearchUsers.Size = new Size(112, 34);
        buttonSearchUsers.TabIndex = 22;
        buttonSearchUsers.Text = "Search";
        buttonSearchUsers.UseVisualStyleBackColor = true;
        buttonSearchUsers.Click += buttonSearchUsers_Click;
        // 
        // listBoxUsers
        // 
        listBoxUsers.FormattingEnabled = true;
        listBoxUsers.Location = new Point(200, 49);
        listBoxUsers.Name = "listBoxUsers";
        listBoxUsers.Size = new Size(307, 454);
        listBoxUsers.TabIndex = 21;
        listBoxUsers.SelectedIndexChanged += listBoxUsers_SelectedIndexChanged;
        // 
        // tabPageComments
        // 
        tabPageComments.Controls.Add(label2);
        tabPageComments.Controls.Add(buttonRemoveComment);
        tabPageComments.Controls.Add(buttonSearchComment);
        tabPageComments.Controls.Add(listBoxComments);
        tabPageComments.Controls.Add(textBoxKeywordComment);
        tabPageComments.Location = new Point(4, 34);
        tabPageComments.Name = "tabPageComments";
        tabPageComments.Padding = new Padding(3);
        tabPageComments.Size = new Size(1053, 557);
        tabPageComments.TabIndex = 2;
        tabPageComments.Text = "Comments";
        tabPageComments.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(536, 84);
        label2.Name = "label2";
        label2.Size = new Size(80, 25);
        label2.TabIndex = 30;
        label2.Text = "keyword";
        // 
        // buttonRemoveComment
        // 
        buttonRemoveComment.Location = new Point(581, 196);
        buttonRemoveComment.Name = "buttonRemoveComment";
        buttonRemoveComment.Size = new Size(112, 34);
        buttonRemoveComment.TabIndex = 23;
        buttonRemoveComment.Text = "Remove";
        buttonRemoveComment.UseVisualStyleBackColor = true;
        buttonRemoveComment.Click += buttonRemoveComment_Click;
        // 
        // buttonSearchComment
        // 
        buttonSearchComment.Location = new Point(745, 109);
        buttonSearchComment.Name = "buttonSearchComment";
        buttonSearchComment.Size = new Size(112, 34);
        buttonSearchComment.TabIndex = 21;
        buttonSearchComment.Text = "Search";
        buttonSearchComment.UseVisualStyleBackColor = true;
        buttonSearchComment.Click += buttonSearchComment_Click;
        // 
        // listBoxComments
        // 
        listBoxComments.FormattingEnabled = true;
        listBoxComments.Location = new Point(195, 51);
        listBoxComments.Name = "listBoxComments";
        listBoxComments.Size = new Size(307, 454);
        listBoxComments.TabIndex = 20;
        listBoxComments.SelectedIndexChanged += listBoxComments_SelectedIndexChanged;
        // 
        // textBoxKeywordComment
        // 
        textBoxKeywordComment.Location = new Point(536, 112);
        textBoxKeywordComment.Name = "textBoxKeywordComment";
        textBoxKeywordComment.Size = new Size(203, 31);
        textBoxKeywordComment.TabIndex = 19;
        // 
        // tabPageEmail
        // 
        tabPageEmail.Controls.Add(textBoxSubjectEmail);
        tabPageEmail.Controls.Add(textBoxBodyEmail);
        tabPageEmail.Controls.Add(buttonSendEmail);
        tabPageEmail.Controls.Add(checkedListBoxUsers);
        tabPageEmail.Location = new Point(4, 34);
        tabPageEmail.Name = "tabPageEmail";
        tabPageEmail.Padding = new Padding(3);
        tabPageEmail.Size = new Size(1053, 557);
        tabPageEmail.TabIndex = 3;
        tabPageEmail.Text = "Email";
        tabPageEmail.UseVisualStyleBackColor = true;
        // 
        // textBoxSubjectEmail
        // 
        textBoxSubjectEmail.Location = new Point(384, 150);
        textBoxSubjectEmail.Name = "textBoxSubjectEmail";
        textBoxSubjectEmail.Size = new Size(304, 31);
        textBoxSubjectEmail.TabIndex = 15;
        // 
        // textBoxBodyEmail
        // 
        textBoxBodyEmail.Location = new Point(384, 214);
        textBoxBodyEmail.Multiline = true;
        textBoxBodyEmail.Name = "textBoxBodyEmail";
        textBoxBodyEmail.Size = new Size(304, 234);
        textBoxBodyEmail.TabIndex = 14;
        // 
        // buttonSendEmail
        // 
        buttonSendEmail.Location = new Point(535, 474);
        buttonSendEmail.Name = "buttonSendEmail";
        buttonSendEmail.Size = new Size(153, 43);
        buttonSendEmail.TabIndex = 13;
        buttonSendEmail.Text = "Send Email";
        buttonSendEmail.UseVisualStyleBackColor = true;
        buttonSendEmail.Click += buttonSendEmail_Click;
        // 
        // checkedListBoxUsers
        // 
        checkedListBoxUsers.FormattingEnabled = true;
        checkedListBoxUsers.Location = new Point(384, 38);
        checkedListBoxUsers.Name = "checkedListBoxUsers";
        checkedListBoxUsers.Size = new Size(304, 88);
        checkedListBoxUsers.TabIndex = 12;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1104, 619);
        Controls.Add(Email);
        Name = "Form1";
        Text = "Social Media Desktop Client";
        Load += Form1_Load;
        Email.ResumeLayout(false);
        tabPagePosts.ResumeLayout(false);
        tabPagePosts.PerformLayout();
        tabPageUsers.ResumeLayout(false);
        tabPageUsers.PerformLayout();
        tabPageComments.ResumeLayout(false);
        tabPageComments.PerformLayout();
        tabPageEmail.ResumeLayout(false);
        tabPageEmail.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TabControl Email;
    private TabPage tabPagePosts;
    private TabPage tabPageUsers;
    private TabPage tabPageComments;
    private TabPage tabPageEmail;
    private Button buttonViewPublishedPosts;
    private Button buttonRemovePost;
    private Button buttonApprove;
    private Button buttonSearch;
    private ListBox listBoxPosts;
    private TextBox textBoxKeyword;
    private ComboBox comboBoxActiveUsers;
    private Button button_ActiveUsers;
    private TextBox textBoxSubjectEmail;
    private TextBox textBoxBodyEmail;
    private Button buttonSendEmail;
    private CheckedListBox checkedListBoxUsers;
    private Button buttonRemoveComment;
    private Button buttonSearchComment;
    private ListBox listBoxComments;
    private TextBox textBoxKeywordComment;
    private Button buttonUpdateUser;
    private Button buttonRemoveUser;
    private Button buttonSearchUsers;
    private ListBox listBoxUsers;
    private TextBox textBoxKeywordUser;
    private TextBox textBoxUserEmail;
    private TextBox textBoxUserName;
    private Label label5;
    private TextBox textBoxUserStatus;
    private Label label4;
    private Label label3;
    private Label label1;
    private Label label2;
}
