const cors = require("cors");
const express = require("express");
const morgan = require("morgan");
const os = require("os");

const app = express();

app.use(cors());
app.use(morgan("tiny"));

app.get("/", (req, res, next) => {
  res.setHeader("Content-Type", "text/plain");
  res.status(200);
  res.send("ciao");
});

app.get("/ciao", (req, res, next) => {
  res.setHeader("Content-Type", "text/plain");
  res.status(200);
  res.send("nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn");
});

app.get("/info", (req, res, next) => {
  let string =
    os.version() +
    " " +
    os.arch() +
    "\ntotalmem: " +
    (os.totalmem() / 1024 / 1024 / 1024).toFixed(2) +
    "GB\nfreemem: " +
    (os.freemem() / 1024 / 1024 / 1024).toFixed(2) +
    "GB";
  res.setHeader("Content-Type", "text/plain");
  res.status(200);
  res.send(string);
});

app.post("/ciao", (req, res, next) => {
  res.setHeader("Content-Type", "text/plain");
  res.status(200);
  res.send("postato");
});

app.listen(3000);
