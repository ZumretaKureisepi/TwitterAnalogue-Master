import { Height } from "@material-ui/icons";
import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { axios } from "../axios";
import "./postEdit.css";

function PostEdit() {
  const [post, setPost] = useState([]);

  const { id } = useParams();

  const getPostById = async () => {
    const response = await axios
      .get("/api/Posts/" + id)
      .catch((err) => console.log("Error:", err));

    if (response && response.data) setPost(response.data);
  };

  useEffect(() => {
    getPostById();
  }, []);

  const Submit = async (values) => {
    await axios
      .post("/api/Posts", values)
      .catch((err) => console.log("Error:", err));
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    Submit(post);
  };

  const handleChange = (e) => {
    setPost((prevState) => ({ ...prevState, postContent: e.target.value }));
  };

  return (
    <>
      <h2>Edit text</h2>
      <form onSubmit={handleSubmit}>
        <div className="postContentInput">
          <textarea onChange={handleChange} value={post.postContent} />
        </div>
        <button type="submit">Save to file</button>
      </form>
    </>
  );
}

export default PostEdit;
