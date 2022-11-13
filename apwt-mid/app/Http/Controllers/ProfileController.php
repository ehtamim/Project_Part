<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Validator;
use Illuminate\Http\Request;
use App\Models\UserModel;
use Illuminate\Support\Facades\Input;

class ProfileController extends Controller
{
    function profileView()
    {
        $usertable = new UserModel();
        if (session()->has('id')) {
            $uid = session()->get('id');
            $employee = $usertable->where('id', $uid);

            if (!empty($uid)) {
                $name = $usertable->where('id', $uid)->pluck('name');
                foreach ($name as $n) {
                    $uname = $n;
                }
                $contact = $usertable->where('id', $uid)->pluck('contact');
                foreach ($contact as $c) {
                    $ucontact = $c;
                }
                $email = $usertable->where('id', $uid)->pluck('email');
                foreach ($email as $e) {
                    $uemail = $e;
                }
                $password = $usertable->where('id', $uid)->pluck('password');
                foreach ($password as $p) {
                    $upassword = $p;
                }
                return view("profile")->with("uname", $uname)
                    ->with("uid", $uid)
                    ->with("ucontact", $ucontact)
                    ->with("uemail", $uemail)
                    ->with("upassword", $upassword);
            } else {
                $output = "Wrong Info";
                return $output;
            }
        }
    }
    function profileUpdate(Request $request)
    {
        $this->validate(
            $request,
            [
                'udname' => 'required|min:6',
                'udcontact' => 'required|max:14|min:11',
                'udemail' => 'regex:/(.+)@(.+)\.(.+)/i',
                'udpassword' => 'min:4'
            ]
        );
        if (isset($error)) {
            $output = "<h1>Submitted</h1>";
            $output .= "udname: " . $request->udname;
            $output .= "<br>udcontact: " . $request->udcontact;
            $output .= "<br>udemail: " . $request->udemail;
            $output .= "<br>udpassword: " . $request->udpassword;
            return $output;
        } else {
            $udname = $request->udname;
            $udcontact = $request->udcontact;
            //$udemail = $email = $request->get('udemail');
            $udemail = $email = $request->udemail;
            $udpassword = $request->udpassword;
            $uid = session()->get('id');
            $usetable = new UserModel();
            $userupdate = $usetable->where('id', $uid)->update(['name' => $request->udname]);
            $userupdate = $usetable->where('id', $uid)->update(['contact' => $request->udcontact]);
            $userupdate = $usetable->where('id', $uid)->update(['email' => $request->udemail]);
            $userupdate = $usetable->where('id', $uid)->update(['password' => $request->udpassword]);
            /*$update = $usetable->where('id', $uid);
            //$usetable = new UserModel();
            $update->name = $request->udname;
            $update->contact = $request->udcontact;
            $update->email = $request->udemail;
            $update->password = $request->udpassword;
            $update->save();*/
            return redirect()->intended('/profile');
            //$update = $usetable->where('id', $uid)->update(['name' => $request->udname])->update(['contact' => $request->udcontact])->update(['email' => $request->udemail])->update(['password' => $request->udpassword]);
            /*$update->name=$request->udname;
     $update->contact=$request->udcontact;
     $update->email=$request->udemail;
     $update->password=$request->udpassword;
     $usetable->save();
     /*return view("profile")->with("udname",$udname)
            ->with("udcontact",$udcontact)
            ->with("udemail",$udemail)
            ->with("udpassword",$udpassword);*/
        }
    }
    function deleteProfile(Request $request)
    {
        $uid = session()->get('id');
        $usetable = new UserModel();
        $userupdate = $usetable->where('id', $uid)->delete();
        return redirect()->intended('/login');
    }
}
