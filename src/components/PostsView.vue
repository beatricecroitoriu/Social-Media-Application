<template>
  <v-container>
    <h2>Social Media Feed</h2>
    <v-btn color="primary" @click="fetchPosts">Load Posts</v-btn>
    <v-list>
      <v-card
          v-for="post in posts"
          :key="post.id"
          class="mb-4"
      >
        <v-card-title>{{ post.title }}</v-card-title>
        <v-card-subtitle>{{ 'Posted by ' + post.user.name + ' on ' + new Date(post.createdOn).toLocaleString()}}</v-card-subtitle>
        <v-card-text>
          {{ post.content }}
        </v-card-text>
        <v-card-actions>
          <v-btn color="blue" @click="viewComments(post)">View Comments</v-btn>
        </v-card-actions>

        <v-expand-transition>
          <comments-view
              v-if="post.showComments"
              :postId="post.id"
              :selectedUser="selectedUser"
          />
        </v-expand-transition>
      </v-card>
    </v-list>
  </v-container>
</template>

<script>
import axios from "axios";
import CommentsView from "@/components/CommentsView.vue";

export default {
  components: { CommentsView },
  data() {
    return {
      posts: [],
    };
  },
  props: ['selectedUser'],
  methods: {
    async fetchPosts() {
      const response = await axios.get("http://localhost:8082/post/published");
      this.posts = response.data.sort((a, b) => new Date(b.createdOn) - new Date(a.createdOn));
      this.posts.forEach(post => {
        post.showComments = false;
      });
    },
    viewComments(post) {
      post.showComments = !post.showComments;
    },
  },
};
</script>
