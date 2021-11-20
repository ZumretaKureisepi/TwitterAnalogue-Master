import React, { useState, useEffect } from "react";
import { axios } from "../axios";
import Post from "./post";

function Feed() {
  const [posts, setPosts] = useState([]);

  const getPosts = async () => {
    const response = await axios
      .get("/api/Posts")
      .catch((err) => console.log("Error:", err));

    if (response && response.data) {
      setPosts(response.data);
    }
  };

  useEffect(() => {
    getPosts();
  }, []);

  console.log("Posts:", posts);

  return (
    <>
      {posts.map((post) => (
        <Post
          postId={post.postId}
          displayName={post.name}
          username={post.username}
          verified={post.verified}
          text={post.postContent}
        />
      ))}
    </>
  );
}

export default Feed;
