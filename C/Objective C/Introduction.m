NSMutableDictionary *aDictionary = [[NSMutableDictionary alloc] init];

[aDictionary setObject: @"foo" forKey: @"Foo"];
[aDictionary setObject: @"bar" forKey: @"Bar"];
[aDictionary setObject: @"Hallo Welt!" forKey: @"Hello, world!"];

NSLog([aDictionary objectForKey: @"Hello, world!"]);

[aDictionary release];