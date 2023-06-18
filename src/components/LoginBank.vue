<template>
    <div id="login">
    <div class="login-page">
      <transition name="fade">
         <div v-if="!registerActive" class="wallpaper-login"></div>
      </transition>
      <div class="wallpaper-register"></div>

      <div class="container">
         <div class="row">
            <div class="col-lg-4 col-md-6 col-sm-8 mx-auto">
               <div v-if="!registerActive" class="card login" v-bind:class="{ error: emptyFields }">
                  <h1>Login</h1>
                  <form class="form-group">
                     <input v-model="emailLogin" type="email" class="form-control" placeholder="Email" required>
                     <input v-model="passwordLogin" type="password" class="form-control" placeholder="Password" required>
                     <div class="col-md-12 text-center mb-3">
                        <button type="submit" class="btn btn-outline-primary mb-2" style="width: 100%;" @click="doLogin">Submit</button>
                        <button type="reset" class="btn btn-outline-primary" style="width: 100%">Reset</button>
                    </div>
                  </form>
               </div>

               <div v-else class="card register" v-bind:class="{ error: emptyFields }">
                  <!-- <h1>Sign Up</h1>
                  <form class="form-group">
                     <input v-model="emailReg" type="email" class="form-control" placeholder="Email" required>
                     <input v-model="passwordReg" type="password" class="form-control" placeholder="Password" required>
                     <input v-model="confirmReg" type="password" class="form-control" placeholder="Confirm Password" required>
                     <input type="submit" class="btn btn-primary" @click="doRegister">
                     <p>Already have an account? <a href="#" @click="registerActive = !registerActive, emptyFields = false">Sign in here</a>
                     </p>
                  </form> -->
               </div>
            </div>
         </div>
      </div>
   </div>
   </div>
</template>

<script>
</script>

<style>
#login {
  background: url("../assets/bgbank.jpg")  no-repeat center center;
  background-size: cover;
  height: 100%;
  position: absolute;
  width: 100%;
}
p {
   color: white;
   line-height: 1rem;
}
.card {
   padding: 20px;
   background-color:rgba(0,0,0,0) !important;
   box-shadow: 0 0 1rem 0 rgba(0,0,0,0.9);
}

.form-group {
   input {
      margin-bottom: 20px;
   }
}

.form-control {
    margin-bottom: 20px;
    background: transparent !important;
    color: white !important;
}

.login-page {
   align-items: center;
   display: flex;
   height: 100vh;   
   
   .fade-enter-active,
   .fade-leave-active {
  transition: opacity .5s;
}
   .fade-enter,
   .fade-leave-to {
      opacity: 0;
   }
}

h1{
    color: white !important;
    text-align: center;
}

.error {
   animation-name: errorShake;
   animation-duration: 0.3s;
}

@keyframes errorShake {
   0% {
      transform: translateX(-25px);
   }
   25% {
      transform: translateX(25px);
   }
   50% {
      transform: translateX(-25px);
   }
   75% {
      transform: translateX(25px);
   }
   100% {
      transform: translateX(0);
   } 
}
</style>
