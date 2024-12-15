package com.utcn.proiect2.user;

import com.utcn.proiect2.post.Post;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;

@Service
public class UserService {

    @Autowired
    private UserRepository userRepository;

    @Transactional
    public User createUser(User user) {
        user.setStatus(UserStatus.ACTIVE); // Default status to ACTIVE
        return userRepository.save(user);
    }

    public List<User> getAllUsers() {
        return userRepository.findAll();
    }

    @Transactional
    public User updateUser(int id, User user) {
        User existingUser = userRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("User not found"));

        existingUser.setName(user.getName());
        existingUser.setEmail(user.getEmail());
        return userRepository.save(existingUser);
    }

    @Transactional
    public void deleteUser(int id) {
        User existingUser = userRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("User not found"));

        existingUser.setStatus(UserStatus.DELETED);
        userRepository.save(existingUser);
    }

    public List<User> getAllActiveUsers() {
        return userRepository.findByStatus(UserStatus.ACTIVE);
    }

}
