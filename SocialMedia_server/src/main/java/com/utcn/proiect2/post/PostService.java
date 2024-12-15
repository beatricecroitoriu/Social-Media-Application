package com.utcn.proiect2.post;

import com.utcn.proiect2.user.UserStatus;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class PostService {

    @Autowired
    private PostRepository postRepository;

    @Transactional
    public Post createPost(Post post) {
        post.setStatus(Status.PENDING);
        return postRepository.save(post);
    }

    public List<Post> findAllPosts(){
        return postRepository.findAll();
    }

    @Transactional
    public Post updatePost(int postId, Post newPostData) {
        Post existingPost = postRepository.findById(postId)
                .orElseThrow(() -> new RuntimeException("Post not found"));
        existingPost.setTitle(newPostData.getTitle());
        existingPost.setContent(newPostData.getContent());
        return postRepository.save(existingPost);
    }

    @Transactional
    public void deletePost(int postId) {
        Post post = postRepository.findById(postId)
                .orElseThrow(() -> new RuntimeException("Post not found"));

        post.setStatus(Status.REMOVED);
        postRepository.save(post);
    }

    @Transactional
    public Post approvePost(int postId) {
        Post post = postRepository.findById(postId)
                .orElseThrow(() -> new RuntimeException("Post not found"));

        if (post.getStatus() != Status.PENDING) {
            throw new RuntimeException("Post cannot be approved as it is not in PENDING status");
        }

        post.setStatus(Status.PUBLISHED);
        return postRepository.save(post);
    }

    public List<Post> getAllPublishedPostsForUser(int userId) {
        return postRepository.findPublishedPostsByUserId(userId);
    }

    public List<Post> getAllPublishedPosts() {
        return postRepository.findPublishedPosts();
    }

    public List<Post> getAllPendingPostsForUser(int userId) {
        return postRepository.findPendingPostsByUserId(userId);
    }

    public List<Post> getAllRemovedPostsForUser(int userId) {
        return postRepository.findRemovedPostsByUserId(userId);
    }




}
