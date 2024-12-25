<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>SpamShare Admin Panel</title>
  <link rel="stylesheet" href="styles.css">
</head>
<body>
  <div id="app">
    <h1>Welcome to SpamShare Admin</h1>

    <!-- Adminer Embedded Section -->
    <div id="adminer">
      <h2>Admin Database Management</h2>
      <iframe src="/adminer/adminer.php" width="100%" height="800px" frameborder="0"></iframe>
    </div>

    <!-- Login Section -->
    <div id="login">
      <h2>Login</h2>
      <input id="username" type="text" placeholder="Username" />
      <input id="password" type="password" placeholder="Password" />
      <button onclick="login()">Login</button>
    </div>

    <!-- Registration Section -->
    <div id="register">
      <h2>Register</h2>
      <input id="register-username" type="text" placeholder="Username" />
      <input id="register-password" type="password" placeholder="Password" />
      <button onclick="register()">Register</button>
    </div>

    <!-- Spam Share Section -->
    <div id="spam">
      <h2>Spam Share</h2>
      <input id="link" type="text" placeholder="Link to Spam" />
      <input id="cookies" type="text" placeholder="Cookies" />
      <input id="interval" type="number" placeholder="Interval (ms)" />
      <input id="shares" type="number" placeholder="Number of Shares" />
      <button onclick="shareSpam()">Start Spam Share</button>
    </div>
  </div>

  <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>
  <script src="app.js"></script>
</body>
</html>
