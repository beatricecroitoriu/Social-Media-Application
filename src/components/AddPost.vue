<template>
  <v-dialog v-model="localShowDialog" max-width="500px">
    <v-card>
      <v-card-title>Create New Post</v-card-title>
      <v-card-text>
        <v-text-field v-model="post.title" label="Title"></v-text-field>
        <v-textarea v-model="post.content" label="Content"></v-textarea>
      </v-card-text>
      <v-card-actions>
        <v-btn color="green" @click="createPost">Create</v-btn>
        <v-btn color="red" @click="closeDialog">Cancel</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from "axios";

export default {
  props: ["showDialog", "userId"],
  data() {
    return {
      post: { title: "", content: "" },
      localShowDialog: this.showDialog,
    };
  },
  watch: {
    showDialog(newValue) {
      this.localShowDialog = newValue;
    },
  },
  methods: {
    async createPost() {
      if (!this.userId) {
        alert("Please select a user before creating a post.");
        return;
      }

      if (!this.post.title || !this.post.content) {
        alert("Please fill in all fields before creating a post.");
        return;
      }

      try {
        const payload = {
          title: this.post.title,
          content: this.post.content,
          user: { id: this.userId },
        };

        await axios.post("http://localhost:8082/post", payload);
        this.$emit("post-created");
        this.post = { title: "", content: "" };
        this.closeDialog();
      } catch (error) {
        console.error("Error creating post:", error);
      }
    },
    closeDialog() {
      this.localShowDialog = false;
      this.$emit("update:showDialog", false);
    },
  },
};
</script>
