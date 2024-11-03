package com.utcn.proiect2.post;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class PostService {

    @Autowired
    private PostRepository postRepository;

    @Transactional
    public Post create(Post myPost) {
        return postRepository.save(myPost);
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
        existingPost.setStatus(newPostData.getStatus());
        return postRepository.save(existingPost);
    }

    @Transactional
    public void deletePost(int postId) {
        if (!postRepository.existsById(postId)) {
            throw new RuntimeException("Post not found");
        }
        postRepository.deleteById(postId);
    }

    //to do UPDATE
    //to do DELETE

    public List<Post> getAllPublishedPostsForUser(int userId) {
        return postRepository.findByUserIdAndStatus(userId, Status.PUBLISHED);
    }

    //public List<Comment> getAllCommentsForPost(int postId) {
     //   return postRepository.findCommentsByPostId(postId);
   // }

}
