<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;
use App\Models\UserModel;

class RegisterController extends Controller
{
    function getregister(Request $request)
    {
    $this->validate($request,
       [ 'name'=>'required|regex:/[a-zA-Z]+(?:\s[a-zA-Z]+)+$/',
       'id'=>'required|regex:/[^a-zA-Z]/',
       'contact'=>'required|max:14',
        'email'=>'required|regex:/(.+)@(.+)\.(.+)/i',
        'password'=>'required|min:6|regex:/^.*(?=.{3,})(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[\d\x])(?=.*[!$#%]).*$/',
        'file'=>'required|max:1000'
    ]
    );
    if (isset($error))
    {
    $output="<h1>Submitted</h1>";
    $output.="username: ".$request->username;
    $output.="<br>email: ".$request->email;
    $output.="<br>email: ".$request->dob;
    $output.="<br>lan: ".$request->lan;
    $output.="<br>file: ".$request->file;
    return $output;
    }
    else{
        $usetable=new UserModel();
        $usetable->name=$request->name;
        $usetable->id=$request->id;
        $usetable->contact=$request->contact;
        $usetable->email=$request->email;
        $usetable->password=$request->password;
        $usetable->save();
        return view('login');
    }
    }
    /*function getregisterwith()
    {
        $ages=['wname'=>$name,'wage'=>23,'wemail'=>'xyz@gmail.com'];
        return view("register")->with("ages",$ages);
    }*/
}

?>
