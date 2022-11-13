<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\UserModel;

class loginController extends Controller
{
    function checklogin(Request $request)
    {
        $gotPassword="";
        $usertable=new UserModel();
        $givenID=$request->id;
        $givenPassword=$request->password;
        $testID= $usertable->where('id', $givenID)->pluck('id');
        $testPassword = $usertable->where('id', $givenID)->pluck('password');
            /*foreach ($testID as $i) 
            {
                $gotID = $i;
            }*/
            foreach ($testPassword as $p) {
                $gotPassword = $p;
            }
            if ($gotPassword==$givenPassword)
            {
                ////$uid=$request->id;
            session()->put("id",$givenID);
            return redirect()->intended('/dashboard');
            }
            else
        {
            $output="Given Input IS not Correct";
            return $output;
        }
        /*$result=$usertable->where('id',$request->id)->where('password',$request->password);
        if(!empty($result))
        {
            //return view("profile")->with("name",$request->name);
            $uid=$request->id;
            session()->put("id",$uid);
            return redirect()->intended('/dashboard');
        }
        else
        {
            $output="Wrong Info";
            return $output;
        }*/
    }
}
