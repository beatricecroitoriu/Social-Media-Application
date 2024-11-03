package com.utcn.proiect2.comment;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.util.List;

public interface CommentRepository extends JpaRepository<Comment, Integer> {
    @Query(value = "SELECT * FROM Comment c WHERE c.post_id = :postId", nativeQuery = true)
    List<Comment> findCommentsByPostId(@Param("postId") int postId);
}