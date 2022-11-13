<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class LogoutController extends Controller
{
    function logoutUser(Request $request)
    {
        session()->forget('id');
        return redirect()->intended('/login');
    }
}
