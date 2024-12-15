<template>
  <v-dialog v-model="localShowDialog" max-width="500px">
    <v-card>
      <v-card-title>Edit Post</v-card-title>
      <v-card-text>
        <v-textarea v-model="localComment.content" label="Content"></v-textarea>
      </v-card-text>
      <v-card-actions>
        <v-btn color="green" @click="editComment">Edit</v-btn>
        <v-btn color="red" @click="closeDialog">Cancel</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from "axios";

export default {
  props: ["showDialog", "commentId", "comment"],
  data() {
    return {
      localShowDialog: this.showDialog,

      localComment: JSON.parse(JSON.stringify(this.comment)),
    };
  },
  watch: {
    showDialog(newValue) {
      this.localShowDialog = newValue;
    }
  },
  methods: {
    async editComment() {
      try {

        const response = await axios.put(`http://localhost:8082/comment/${this.commentId}`, {
          content: this.localComment.content,
        });


        this.$emit("comment-updated", response.data);
        this.closeDialog();
      } catch (error) {
        console.error("Error updating comment:", error);
      }
    },
    closeDialog() {
      this.localShowDialog = false;
      this.$emit("update:showDialog", false);
    },
  },
};
</script>
