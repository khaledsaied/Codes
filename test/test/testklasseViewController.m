//
//  testklasseViewController.m
//  test
//
//  Created by Khaled Saied on 12/02/13.
//  Copyright (c) 2013 Khaled Saied. All rights reserved.
//

#import "testklasseViewController.h"

@interface testklasseViewController ()

@end

@implementation testklasseViewController

- (void)viewDidLoad
{
    [super viewDidLoad];
	// Do any additional setup after loading the view, typically from a nib.
}

- (void)didReceiveMemoryWarning
{
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

- (IBAction)knap:(id)sender {
    self.output.text = self.input.text;
}
@end
