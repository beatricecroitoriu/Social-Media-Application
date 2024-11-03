package com.utcn.proiect2.post;

import com.utcn.proiect2.comment.Comment;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import java.util.List;

public interface PostRepository extends JpaRepository<Post, Integer> {
    @Query(value = "SELECT * FROM Post p WHERE p.user_id = :userId AND p.status = 'PUBLISHED'", nativeQuery = true)
    List<Post> findPublishedPostsByUserId(@Param("userId") int userId);
}