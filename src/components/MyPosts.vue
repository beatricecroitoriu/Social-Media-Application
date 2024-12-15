<template>
  <v-container>
    <v-tabs v-model="tab">
      <v-tab>Published</v-tab>
      <v-tab>Pending</v-tab>
      <v-tab>Removed</v-tab>
    </v-tabs>

    <v-tab-item>
      <v-list>
        <v-card
            v-for="post in publishedPosts"
            :key="post.id"
            class="mb-4"
        >
          <v-card-title>{{ post.title }}</v-card-title>
          <v-card-subtitle>{{ 'Created on ' + new Date(post.createdOn).toLocaleString() }}</v-card-subtitle>
          <v-card-text>{{ post.content }}</v-card-text>
          <v-card-actions>
            <v-btn color="orange" @click="openEditDialog(post)">Edit</v-btn>
            <edit-post
                v-model:showDialog="showEditDialog"
                :userId="selectedUser.id"
                :postId="post.id"
                :post="post"
            />
            <v-btn color="red" @click="deletePost(post.id)">Delete</v-btn>
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
    </v-tab-item>

    <v-tab-item>
      <v-list>
        <v-card
            v-for="post in pendingPosts"
            :key="post.id"
            class="mb-4"
        >
          <v-card-title>{{ post.title }}</v-card-title>
          <v-card-subtitle>{{ 'Created on ' + new Date(post.createdOn).toLocaleString() }}</v-card-subtitle>
          <v-card-text>{{ post.content }}</v-card-text>
          <v-card-actions>
            <v-btn color="orange" @click="openEditDialog(post)">Edit</v-btn>
            <edit-post
                v-model:showDialog="showEditDialog"
                :userId="selectedUser.id"
                :postId="post.id"
                :post="post"
            />
            <v-btn color="red" @click="deletePost(post.id)">Delete</v-btn>
          </v-card-actions>
        </v-card>
      </v-list>
    </v-tab-item>

    <v-tab-item>
      <v-list>
        <v-card
            v-for="post in removedPosts"
            :key="post.id"
            class="mb-4"
        >
          <v-card-title>{{ post.title }}</v-card-title>
          <v-card-subtitle>{{ 'Created on ' + new Date(post.createdOn).toLocaleString() }}</v-card-subtitle>
          <v-card-text>{{ post.content }}</v-card-text>
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
    </v-tab-item>
  </v-container>
</template>

<script>
import axios from 'axios';
import CommentsView from "@/components/CommentsView.vue";
import EditPost from "@/components/EditPost.vue";

export default {
  components: { EditPost, CommentsView },
  data() {
    return {
      tab: 0,
      publishedPosts: [],
      pendingPosts: [],
      removedPosts: [],
      showEditDialog: false,
      currentPost: null,
    };
  },
  props: ['selectedUser'],
  watch: {
    selectedUser(newUser) {
      if (newUser) {
        this.fetchMyPosts(newUser.id);
      }
    },
    tab() {
      if (this.selectedUser) {
        this.fetchMyPosts(this.selectedUser.id);
      }
    }
  },
  methods: {
    async fetchMyPosts(userId) {
      try {
        this.publishedPosts = [];
        this.pendingPosts = [];
        this.removedPosts = [];

        if (this.tab === 0) {
          const response = await axios.get(`http://localhost:8082/post/published/${userId}`);
          this.publishedPosts = response.data;
        } else if (this.tab === 1) {
          const response = await axios.get(`http://localhost:8082/post/pending/${userId}`);
          this.pendingPosts = response.data;
        } else if (this.tab === 2) {
          const response = await axios.get(`http://localhost:8082/post/removed/${userId}`);
          this.removedPosts = response.data;
        }
      } catch (error) {
        console.error("Error fetching posts for the user:", error);
      }
    },
    openEditDialog(post) {
      this.currentPost = post;
      this.showEditDialog = true;
      this.fetchMyPosts(this.selectedUser.id);
    },
    async deletePost(id) {
      await axios.delete(`http://localhost:8082/post/${id}`);
      this.fetchMyPosts(this.selectedUser.id);
    },
    viewComments(post) {
      post.showComments = !post.showComments;
    },
  }
};
</script>
