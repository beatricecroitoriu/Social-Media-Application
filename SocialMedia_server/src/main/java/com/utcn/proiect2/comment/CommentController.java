package com.utcn.proiect2.comment;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import com.utcn.proiect2.user.User;
import com.utcn.proiect2.user.UserRepository;
import com.utcn.proiect2.post.Post;
import com.utcn.proiect2.post.PostRepository;

import java.util.List;

@RestController
@RequestMapping("/comment")
@CrossOrigin
public class CommentController {

    @Autowired
    private CommentService commentService;

    @Autowired
    private UserRepository userRepository;

    @Autowired
    private PostRepository postRepository;

    @PostMapping
    public Comment createComment(@RequestBody CommentRequest request) {
        User user = userRepository.findById(request.getUserId())
                .orElseThrow(() -> new RuntimeException("User not found"));
        Post post = postRepository.findById(request.getPostId())
                .orElseThrow(() -> new RuntimeException("Post not found"));

        Comment comment = new Comment();
        comment.setContent(request.getContent());
        comment.setUser(user);
        comment.setPost(post);
        return commentService.createComment(comment);
    }

    @GetMapping
    public List<Comment> getAllComments() {
        return commentService.findAllComments();
    }

    @PutMapping("/{id}")
    public Comment updateComment(@PathVariable int id, @RequestBody CommentRequest request) {
        return commentService.updateComment(id, new Comment(request.getContent()));
    }

    @DeleteMapping("/{id}")
    public void deleteComment(@PathVariable int id) {
        commentService.deleteComment(id);
    }

    @GetMapping("/post/{postId}")
    public List<Comment> getAllCommentsForPost(@PathVariable int postId) {
        return commentService.getAllCommentsForPost(postId);
    }
}
