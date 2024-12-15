package com.utcn.proiect2.user;

import com.utcn.proiect2.post.Post;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.util.List;

public interface UserRepository extends JpaRepository<User, Integer> {
    List<User> findByStatus(UserStatus status);

}