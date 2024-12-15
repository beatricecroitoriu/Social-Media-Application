<template>
  <v-card>
    <v-layout>
      <v-navigation-drawer expand-on-hover rail>
        <v-list>
          <v-list-item
              prepend-avatar="https://img.icons8.com/?size=100&id=AZazdsitsrgg&format=png&color=000000"
              :title="selectedUser.name"
              :subtitle="selectedUser.email"
          ></v-list-item>
        </v-list>

        <v-divider></v-divider>

        <v-list density="compact" nav>
          <v-list-item
              prepend-icon="mdi-account-multiple"
              title="Social Media Feed"
              value="feed"
              @click="scrollToSection('feed')"
          ></v-list-item>
          <v-list-item
              prepend-icon="mdi-folder"
              title="My Posts"
              value="myposts"
              @click="scrollToSection('myposts')"
          ></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <v-main>
        <v-app>
          <v-container>
            <active-users @user-selected="onUserSelected" />
          </v-container>
          <v-divider></v-divider>
          <section ref="feedSection" style="padding: 20px;">
            <posts-view @view-comments="viewComments" :selected-user="selectedUser" />
          </section>
          <v-divider></v-divider>
          <section ref="myPostsSection" style="padding: 20px;">
            <v-container>
              <h2>My Posts</h2>
              <v-btn color="primary" @click="showAddDialog = true">Create New Post</v-btn>
              <add-post
                  v-model:showDialog="showAddDialog"
                  :userId="selectedUser.id"
                  @post-created="refreshPosts"
              />
            </v-container>
            <my-posts @view-comments="viewComments" :selected-user="selectedUser" />
          </section>

        </v-app>
      </v-main>
    </v-layout>
  </v-card>

</template>

<script>
import PostsView from "./components/PostsView.vue";
import AddPost from "./components/AddPost.vue";
import ActiveUsers from "./components/ActiveUsers.vue";
import MyPosts from "./components/MyPosts.vue";

export default {
  components: {PostsView, AddPost, ActiveUsers, MyPosts},
  data() {
    return {showAddDialog: false, selectedPostId: null, selectedUser: {
        name: "No user selected",
        email: "",
      },};
  },
  methods: {
    scrollToSection(section) {
      if (section === "feed" && this.$refs.feedSection) {
        this.$refs.feedSection.scrollIntoView({ behavior: "smooth" });
      } else if (section === "myposts" && this.$refs.myPostsSection) {
        this.$refs.myPostsSection.scrollIntoView({ behavior: "smooth" });
      }
    },
    refreshPosts() {
      console.log("Post created. Refresh posts...");
    },
    viewComments(postId) {
      this.selectedPostId = postId;
    },
    onUserSelected(user) {
      this.selectedUser = user;
    },
  },
};
</script>
