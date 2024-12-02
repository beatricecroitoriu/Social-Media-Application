namespace SocialMedia_Client2;

public partial class Form1 : Form
{
    PostService postService;
    List<Post> postList;
    public Form1()
    {
        InitializeComponent();
        postService = new PostService();
        postService.createConnection();

    }
    private void button_ActiveUsers_Click(object sender, EventArgs e)
    {
        var usersList = postService.GetActiveUsers();

        comboBox1.DataSource = usersList;
        comboBox1.DisplayMember = "name";
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        string keyword = textBoxKeyword.Text;
        var filteredPosts = postService.GetPostsByKeyword(keyword);

        listBoxPosts.DataSource = filteredPosts;
        listBoxPosts.DisplayMember = "title"; // Sau orice altã proprietate relevantã
    }

    private void buttonApprove_Click(object sender, EventArgs e)
    {
        if (listBoxPosts.SelectedItem is Post selectedPost)
        {
            postService.ApprovePost(selectedPost.id);
        }
    }

    private void buttonRemove_Click(object sender, EventArgs e)
    {
        if (listBoxPosts.SelectedItem is Post selectedPost)
        {
            postService.RemovePost(selectedPost.id);
        }
    }

    private void buttonSendEmail_Click(object sender, EventArgs e)
    {
        var selectedUsers = checkedListBoxUsers.CheckedItems.Cast<User>().ToList();
        var emails = selectedUsers.Select(u => u.email).ToList();

        postService.SendEmailToUsers(emails);
    }

  
}
