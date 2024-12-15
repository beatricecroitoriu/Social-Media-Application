package com.utcn.proiect2.email;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/email")
@CrossOrigin
public class EmailController {

    @Autowired
    private EmailService emailService;

    @PostMapping("/sendEmail")
    public String sendEmail(@RequestBody EmailRequest emailRequest) {
        return emailService.sendEmail(
                emailRequest.getRecipients(),
                emailRequest.getSubject(),
                emailRequest.getBody()
        );
    }
}
