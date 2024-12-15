<template>
  <v-container>
    <v-divider></v-divider>

    <h2>Comments for Post</h2>

    <v-alert v-if="!selectedUser.id" type="error">
      Please select a user to add or manage comments.
    </v-alert>

    <v-list>
      <v-list-item v-for="comment in comments" :key="comment.id">
        <v-list-item-title>
          {{ comment.content }}
          <small>by {{ comment.user.name }} on {{ formatDate(comment.createdOn) }}</small>
        </v-list-item-title>


        <v-btn
            v-if="comment.user.id === selectedUser.id"
            color="blue" @click="openEditDialog(comment)">
          Edit
        </v-btn>
        <edit-comment
            v-model:showDialog="showEditDialog"
            :commentId="comment.id"
            :comment="comment"
        />
        <v-btn
            v-if="comment.user.id === selectedUser.id"
            color="red" @click="deleteComment(comment.id)">
          Delete
        </v-btn>
      </v-list-item>
    </v-list>


    <v-text-field
        v-model="newComment"
        label="Add new comment"
        :disabled="!selectedUser.id"
    ></v-text-field>


    <v-alert v-if="newComment.trim() === '' && selectedUser.id" type="warning">
      Please write a comment before submitting.
    </v-alert>


    <v-btn color="green" @click="addComment" :disabled="!newComment.trim() || !selectedUser.id">
      Add Comment
    </v-btn>
  </v-container>
</template>

<script>
import axios from "axios";
import EditComment from "@/components/EditComment.vue";

export default {
  components: {EditComment},
  props: ["postId", "selectedUser"],
  data() {
    return {
      comments: [],
      newComment: "",
      showEditDialog: false,
      currentComment: null,
    };
  },
  methods: {
    async fetchComments() {
      const response = await axios.get(`http://localhost:8082/comment/post/${this.postId}`);
      this.comments = response.data;
    },
    async addComment() {
      if (!this.selectedUser.id) {
        return;
      }
      await axios.post(`http://localhost:8082/comment`, {
        content: this.newComment,
        userId: this.selectedUser.id,
        postId: this.postId,
      });
      this.newComment = "";
      this.fetchComments();
    },
    async deleteComment(id) {
      await axios.delete(`http://localhost:8082/comment/${id}`, {
        params: {userId: this.selectedUser.id},
      });
      this.fetchComments();
    },
    openEditDialog(comment) {
      this.currentComment = comment;
      this.showEditDialog = true;
      this.fetchComments();
    },
    formatDate(date) {
      return new Date(date).toLocaleString();
    },
  },
  mounted() {
    this.fetchComments();
  },
};
</script>
