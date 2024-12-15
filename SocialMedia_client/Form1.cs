namespace SocialMedia_Client2;

public partial class Form1 : Form
{
    PostService postService;
    UserService userService;
    CommentService commentService;
    EmailService emailService;
    List<Post> postList;
    List<User> userList;
    public Form1()
    {
        InitializeComponent();
        postService = new PostService();
        userService = new UserService();
        emailService = new EmailService();
        commentService = new CommentService();
        userService.createConnection();
        postService.createConnection();
        commentService.createConnection();

    }
    private void button_ActiveUsers_Click(object sender, EventArgs e)
    {
        var usersList = postService.GetActiveUsers();

        comboBoxActiveUsers.DataSource = usersList;
        comboBoxActiveUsers.DisplayMember = "name";
    }



    private void buttonApprove_Click(object sender, EventArgs e)
    {
        if (listBoxPosts.SelectedItem is Post selectedPost)
        {
            postService.ApprovePost(selectedPost.id);
        }
        else
        {
            MessageBox.Show("Please select a post.");
        }
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (listBoxPosts.SelectedItem is Post selectedPost)
        {
            postService.DeletePost(selectedPost.id);
            MessageBox.Show($"Post {selectedPost.title} removed.");
        }
        else
        {
            MessageBox.Show("Please select a post.");
        }
    }


    private void buttonViewPublishedPosts_Click(object sender, EventArgs e)
    {

        if (comboBoxActiveUsers.SelectedItem is User selectedUser)
        {

            var publishedPosts = postService.GetPublishedPostsForUser(selectedUser.id);

            if (publishedPosts != null && publishedPosts.Count > 0)
            {
                listBoxPosts.DataSource = publishedPosts;
                listBoxPosts.DisplayMember = "title";
            }
            else
            {
                MessageBox.Show($"No published posts found for user {selectedUser.name}.");
                listBoxPosts.DataSource = null;
            }
        }
        else
        {
            MessageBox.Show("Please select a user to view their published posts.");
        }
    }

    private async void PopulateCheckedListBoxUsers()
    {
        UserService userService = new UserService();
        List<User> users = userService.GetAllUsers();

        if (users != null && users.Count > 0)
        {
            checkedListBoxUsers.Items.Clear(); 

            foreach (var user in users)
            {
                UserItem userItem = new UserItem(user.name, user.email);
                checkedListBoxUsers.Items.Add(userItem);
            }
        }
        else
        {
            MessageBox.Show("No users found or failed to fetch users.");
        }
    }

    private async void buttonSendEmail_Click(object sender, EventArgs e)
    {
        EmailService emailService = new EmailService();

        var selectedRecipients = checkedListBoxUsers.CheckedItems
            .Cast<UserItem>() 
            .Select(item => item.Email) 
            .ToArray();

        if (selectedRecipients.Length == 0)
        {
            MessageBox.Show("Select at least one recipient.");
            return;
        }

        EmailRequest emailRequest = new EmailRequest
        {
            recipients = selectedRecipients,
            subject = textBoxSubjectEmail.Text,
            body = textBoxBodyEmail.Text
        };

     
        string result = await emailService.SendEmail(emailRequest);


        MessageBox.Show(result);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        PopulateCheckedListBoxUsers();
    }
    private void buttonSearch_Click(object sender, EventArgs e)
    {
        string keyword = textBoxKeyword.Text;
        var filteredPosts = postService.GetPostsByKeyword(keyword);

        listBoxPosts.DataSource = filteredPosts;
        listBoxPosts.DisplayMember = "title";
    }

    private void buttonSearchUsers_Click(object sender, EventArgs e)
    {
        string keyword = textBoxKeywordUser.Text;
        var filteredUsers = userService.GetUsersByKeyword(keyword);

        listBoxUsers.DataSource = filteredUsers;
        listBoxUsers.DisplayMember = "name";
    }

    private void buttonSearchComment_Click(object sender, EventArgs e)
    {
        string keyword = textBoxKeywordComment.Text;
        var filteredComments = commentService.GetCommentsByKeyword(keyword);

        listBoxComments.DataSource = filteredComments;
        listBoxComments.DisplayMember = "content";
    }


    private async void buttonUpdateUser_Click(object sender, EventArgs e)
    {
        if (listBoxUsers.SelectedItem is User selectedUser)
        {
            
            selectedUser.name = textBoxUserName.Text;
            selectedUser.email = textBoxUserEmail.Text;

            try
            {
                await userService.UpdateUserAsync(selectedUser.id, selectedUser);
                MessageBox.Show("User updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
        }
        else
        {
            MessageBox.Show("Please select a user to update.");
        }
    }

    private void buttonRemoveUser_Click(object sender, EventArgs e)
    {
        if (listBoxUsers.SelectedItem is User selectedUser)
        {
            userService.DeleteUser(selectedUser.id);
            MessageBox.Show($"User {selectedUser.name} removed.");
        }
        else
        {
            MessageBox.Show("Please select a user.");
        }
    }



    private void buttonRemoveComment_Click(object sender, EventArgs e)
    {

        if (listBoxComments.SelectedItem is Comment selectedComment)
        {
            commentService.DeleteComment(selectedComment.id);
            MessageBox.Show($"Comment removed.");
            
        }
        else
        {
            MessageBox.Show("Please select a comment.");
        }
    }

    private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listBoxUsers.SelectedItem is User selectedUser)
        {
            textBoxUserName.Text = selectedUser.name;
            textBoxUserEmail.Text = selectedUser.email;
            textBoxUserStatus.Text = selectedUser.status.ToString();
        }
    }

    private void listBoxComments_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
