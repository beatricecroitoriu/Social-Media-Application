package com.utcn.proiect2.email;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.stereotype.Service;

@Service
public class EmailService {

    @Autowired
    private JavaMailSender emailSender;

    public String sendEmail(String[] recipients, String subject, String body) {
        try {
            SimpleMailMessage message = new SimpleMailMessage();
            message.setTo(recipients);
            message.setSubject(subject);
            message.setText(body);
            emailSender.send(message);
            return "Emailuri trimise cu succes!";
        } catch (Exception e) {
            throw new RuntimeException("Eroare la trimiterea emailurilor: " + e.getMessage(), e);
        }
    }
}
