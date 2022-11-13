<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\PagesController;
use App\Http\Controllers\RegisterController;
use App\Http\Controllers\ProfileController;
use App\Http\Controllers\loginController;
use App\Http\Controllers\LogoutController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});
Route::get('/login', function () {
    return view('login');
});
Route::get('/register', function () {
    return view('register');
});
Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware('checklogin');

Route::get('/clear-cache', function() {
    $exitCode = Artisan::call('cache:clear');
    return redirect()->intended('/login');
});

Route::get('/home', [PagesController::class, 'home']);
Route::get('/logout', [LogoutController::class, 'logoutUser']);
Route::post('/register', [RegisterController::class, 'getregister']);
Route::post('/login', [loginController::class, 'checklogin']);
Route::get('/profile', [ProfileController::class, 'profileView'])->middleware('checklogin');
Route::post('/profileUpdate', [ProfileController::class, 'profileUpdate']);
Route::get('/deleteProfile', [ProfileController::class, 'deleteProfile']);
//Route::post('/register', [RegisterController::class, 'getregister']);
//Route::get('/dashboard', [RegisterController::class, 'getregister'])->middleware('checklogin');

//Route::get('/register', [RegisterController::class,'getregisterwith'] );
