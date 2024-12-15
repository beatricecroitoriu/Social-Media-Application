<template>
  <v-dialog v-model="localShowDialog" max-width="500px">
    <v-card>
      <v-card-title>Edit Post</v-card-title>
      <v-card-text>
        <v-text-field v-model="localPost.title" label="Title"></v-text-field>
        <v-textarea v-model="localPost.content" label="Content"></v-textarea>
      </v-card-text>
      <v-card-actions>
        <v-btn color="green" @click="editPost">Edit</v-btn>
        <v-btn color="red" @click="closeDialog">Cancel</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from "axios";

export default {
  props: ["showDialog", "userId", "postId", "post"],
  data() {
    return {
      localShowDialog: this.showDialog,

      localPost: JSON.parse(JSON.stringify(this.post)),
    };
  },
  watch: {
    showDialog(newValue) {
      this.localShowDialog = newValue;
    }
  },
  methods: {
    async editPost() {
      try {

        const response = await axios.put(`http://localhost:8082/post/${this.postId}`, {
          title: this.localPost.title,
          content: this.localPost.content,
          userId: this.userId
        });


        this.$emit("post-updated", response.data);
        this.closeDialog();
      } catch (error) {
        console.error("Error updating post:", error);
      }
    },
    closeDialog() {
      this.localShowDialog = false;
      this.$emit("update:showDialog", false);
    },
  },
};
</script>
