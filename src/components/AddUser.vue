<template>
  <v-dialog v-model="localShowDialog" max-width="500px">
    <v-card>
      <v-card-title>Create User</v-card-title>
      <v-card-text>
        <v-text-field v-model="user.name" label="Full Name"></v-text-field>
        <v-text-field v-model="user.email" label="Email"></v-text-field>
      </v-card-text>
      <v-card-actions>
        <v-btn color="green" @click="createUser">Create</v-btn>
        <v-btn color="red" @click="closeDialog">Cancel</v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import axios from "axios";

export default {
  props: ["showDialog"],
  data() {
    return {
      user: { name: "", email: "" },
      localShowDialog: this.showDialog,
    };
  },
  watch: {
    showDialog(newValue) {
      this.localShowDialog = newValue;
    },
  },
  methods: {
    async createUser() {
      if (!this.user.name || !this.user.email) {
        alert("Please fill in all fields before creating a user.");
        return;
      }
      try {
        await axios.post("http://localhost:8082/user", this.user);
        this.$emit("user-created");
        this.user = { name: "", email: "" };
        this.closeDialog();
      } catch (error) {
        console.error("Error creating user:", error);
      }
    },
    closeDialog() {
      this.localShowDialog = false;
      this.$emit("update:showDialog", false);
    },
  },
};
</script>
