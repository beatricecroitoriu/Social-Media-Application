<template>
  <v-container>
    <h2>Select an user</h2>
    <v-btn color="primary" @click="showCreateDialog = true">Create User</v-btn>

    <v-list>
      <v-list-item
          v-for="user in users"
          :key="user.id"
          @click="selectUser(user)"
          :class="{ 'active-user': selectedUser && selectedUser.id === user.id }"
      >
        <v-list-item-content>
          <v-list-item-title>{{ user.name }}</v-list-item-title>
        </v-list-item-content>
      </v-list-item>
    </v-list>
    <add-user
        v-model:showDialog="showCreateDialog"
        @user-created="fetchActiveUsers"
    />
  </v-container>
</template>

<script>
import axios from 'axios';
import AddUser from './AddUser.vue';

export default {
  components: {AddUser},
  data() {
    return {
      users: [],
      selectedUser: null,
      showCreateDialog: false,
    };
  },
  methods: {
    async fetchActiveUsers() {
      try {
        const response = await axios.get("http://localhost:8082/user/active");
        this.users = response.data;
      } catch (error) {
        console.error("Error fetching active users:", error);
      }
    },
    selectUser(user) {
      this.selectedUser = user;
      this.$emit('user-selected', user);
    },
  },
  created() {
    this.fetchActiveUsers();
  },
};
</script>

<style scoped>
.active-user {
  background-color: #e0e0e0;
}
</style>
