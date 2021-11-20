import { Avatar } from "@material-ui/core";
import {
  ChatBubbleOutline,
  FavoriteBorder,
  Publish,
  Repeat,
  VerifiedUser,
} from "@material-ui/icons";
import React from "react";
import "./post.css";
import { Link } from "react-router-dom";

function Post({ postId, displayName, username, verified, text }) {
  return (
    <div className="post">
      <div className="post_avatar">
        <Avatar src="/team.jpg" />¸
      </div>

      <div className="post_body">
        <div className="post_header">
          <div className="post_headerText">
            <h3>
              {displayName}{" "}
              <span className="post_headerSpecial">
                {verified && <VerifiedUser className="post_badge" />} @
                {username}
              </span>
            </h3>
          </div>

          <div className="post_headerDescription">
            <p>{text}</p>
          </div>
          <Link to={`/postEdit/${postId}`} className="btn btn-primary btn-sm">
            Edit Text
          </Link>
        </div>
        <img src="/female-developer.jpg" alt="" />
      </div>
    </div>
  );
}

export default Post;
