package com.utcn.proiect2.comment;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class CommentService {

    @Autowired
    private CommentRepository commentRepository;

    @Transactional
    public Comment create(Comment comment) {
        return commentRepository.save(comment);
    }

    @Transactional
    public Comment updateComment(int commentId, Comment newCommentData) {
        Comment existingComment = commentRepository.findById(commentId)
                .orElseThrow(() -> new RuntimeException("Comment not found"));
        existingComment.setContent(newCommentData.getContent());
        return commentRepository.save(existingComment);
    }

    @Transactional
    public void deleteComment(int commentId) {
        if (!commentRepository.existsById(commentId)) {
            throw new RuntimeException("Comment not found");
        }
        commentRepository.deleteById(commentId);
    }

    public List<Comment> getAllCommentsForPost(int postId) {
        return commentRepository.findCommentsByPostId(postId);
    }
}