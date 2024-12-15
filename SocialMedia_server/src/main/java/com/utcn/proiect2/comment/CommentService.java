package com.utcn.proiect2.comment;

import com.utcn.proiect2.post.Post;
import com.utcn.proiect2.post.PostRepository;
import com.utcn.proiect2.user.User;
import com.utcn.proiect2.user.UserRepository;
import com.utcn.proiect2.user.UserStatus;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;


@Service
public class CommentService {

    @Autowired
    private CommentRepository commentRepository;

    @Transactional
    public Comment createComment(Comment comment) {
        return commentRepository.save(comment);
    }

    public List<Comment> findAllComments() {
        return commentRepository.findAll();
    }

    @Transactional
    public Comment updateComment(int commentId, Comment newCommentData) {
        Comment existingComment = commentRepository.findById(commentId)
                .orElseThrow(() -> new RuntimeException("Comment not found"));
        existingComment.setContent(newCommentData.getContent());
        return commentRepository.save(existingComment);
    }

    public void deleteComment(int commentId) {
        commentRepository.deleteById(commentId);
    }

    public List<Comment> getAllCommentsForPost(int postId) {
        return commentRepository.findCommentsByPostId(postId);
    }
}
