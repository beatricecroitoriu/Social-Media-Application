package com.utcn.proiect2.comment;

import lombok.Data;

@Data
public class CommentRequest {
    private String content;
    private int userId;
    private int postId;
}
