package com.utcn.proiect2.post;

import com.utcn.proiect2.comment.Comment;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import java.util.List;

public interface PostRepository extends JpaRepository<Post, Integer> {
    List<Post> findByUserIdAndStatus(int userId, Status status);

    @Query("SELECT c FROM Comment c WHERE c.post.id = :postId")
    List<Comment> findCommentsByPostId(@Param("postId") int postId);
}