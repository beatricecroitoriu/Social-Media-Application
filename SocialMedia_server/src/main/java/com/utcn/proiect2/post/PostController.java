package com.utcn.proiect2.post;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.*;
import com.utcn.proiect2.email.EmailRequest;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/post")
@CrossOrigin
public class PostController {

    @Autowired
    private PostService postService;

    @PostMapping
    public Post createPost(@RequestBody Post post)
    {
        return postService.createPost(post);
    }

    @GetMapping
    public List<Post> getAllPosts(){
        return postService.findAllPosts();
    }

    @PutMapping("/{id}")
    public Post updatePost(@PathVariable int id, @RequestBody Post post) {
        return postService.updatePost(id, post);
    }

    @DeleteMapping("/{id}")
    public void deletePost(@PathVariable int id) {
        postService.deletePost(id);
    }

    @PutMapping("/{postId}/approve")
    public ResponseEntity<Post> approvePost(@PathVariable int postId) {
        try {
            Post approvedPost = postService.approvePost(postId);
            return ResponseEntity.ok(approvedPost);
        } catch (RuntimeException e) {
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(null);
        }
    }

    @GetMapping("/published/{userId}")
    public List<Post> getAllPublishedPostsForUser(@PathVariable int userId) {
        return postService.getAllPublishedPostsForUser(userId);
    }

    @GetMapping("/published")
    public List<Post> getAllPublishedPosts() {
        return postService.getAllPublishedPosts();
    }

    @GetMapping("/pending/{userId}")
    public List<Post> getAllPendingPostsForUser(@PathVariable int userId) {
        List<Post> pendingPosts = postService.getAllPendingPostsForUser(userId);
        return pendingPosts;
    }

    @GetMapping("/removed/{userId}")
    public List<Post> getAllRemovedPostsForUser(@PathVariable int userId) {
        return postService.getAllRemovedPostsForUser(userId);
    }

}