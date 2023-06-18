<template>
<nav class="navbar navbar-expand-lg navbar-dark bg-dark px-0 py-3">
  <div class="container-xl">
    <!-- Logo -->
    <ul class="navbar-brand">
        <li class="alttext"><a href="#"><img src="@/assets/bgbankico.png"></a>&nbsp;BankApplication</li>
    </ul>
    <!-- Navbar toggle -->
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <!-- Collapse -->
    <div class="collapse navbar-collapse" id="navbarCollapse">
      <!-- Nav -->
      <div class="navbar-nav mx-lg-auto">
        <a class="nav-item nav-link" href="#">Home</a>
        <a class="nav-item nav-link" href="#">About</a>
      </div>
      <!-- Right navigation -->
      <div class="navbar-nav ms-lg-4">
        <a class="nav-item nav-link" href="#">Logout</a>
      </div>
      <!-- Action -->
      <div class="d-flex align-items-lg-center mt-3 mt-lg-0">
        <a href="#" class="btn btn-sm btn-primary w-full w-lg-auto">
          Register
        </a>
      </div>
    </div>
  </div>
</nav>
<div class="row justify-content-center">
    <div class="col-auto">
    <table class="table table-striped table-hover">
        <thead>
        <tr>
        <th scope="col">CustID</th>
        <th scope="col">AccId</th>
        <th scope="col">Name</th>
        <th scope="col">City</th>
        <th scope="col">Address</th>
        <th scope="col">DOB</th>
        <th scope="col">Open Balance</th>
        <th scope="col">Mobile No</th>
        <th scope="col">A Status</th>
        <th scope="col">A Type</th>
        <th scope="col">Occupation</th>
        <th scope="col">Actions</th>
        </tr>
        </thead>
        <tbody>
        <tr>
        <th scope="row">1</th>
        <td>Mark</td>
        <td>Otto</td>
        <td>@mdo</td>
        </tr>
        <tr>
        <th scope="row">2</th>
        <td>Jacob</td>
        <td>Thornton</td>
        <td>@fat</td>
        </tr>
        <tr>
        <th scope="row">3</th>
        <td colspan="2">Larry the Bird</td>
        <td>@twitter</td>
        </tr>
        </tbody>
        </table>
    </div>
</div>
</template>

<script></script>

<style>
html, body {
    max-width: 100%;
    overflow-x: hidden;
}
ul {
    list-style-type: none;
}
li{
    font-size: larger;
}
table{
    margin-top: 30px;
}
</style>
