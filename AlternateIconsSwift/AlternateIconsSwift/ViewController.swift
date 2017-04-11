//
//  ViewController.swift
//  AlternateIconsSwift
//
//  Created by Cesar Cavazos on 4/6/17.
//  Copyright © 2017 Propelics. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    func changeAppIcon(iconName: String?) {
        if UIApplication.shared.supportsAlternateIcons {
            print("App Icon can be changed")
        } else{
            print("App Icon cannot be changed")
            return
        }
        
        UIApplication.shared.setAlternateIconName(iconName) { (err:Error?) in
            if let error = err {
                print("Error changing the icon ", error.localizedDescription)
            }
        }
    }
    
    @IBAction func handleAlternateIcon2(_ sender: Any) {
        changeAppIcon(iconName: "propelicsLightTheme")
    }
    
    @IBAction func handleAlternateIcon1(_ sender: Any) {
        changeAppIcon(iconName: "propelicsDarkTheme")
    }
    
    @IBAction func handleDefaultIcon(_ sender: Any) {
        changeAppIcon(iconName: nil)
    }
}

