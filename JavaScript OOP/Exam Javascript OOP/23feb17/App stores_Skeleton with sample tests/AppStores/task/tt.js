class Device{
		constructor(hostname, apps){
			if(typeof hostname !== 'string' || hostname.length < 1 || hostname.length > 32){
				throw Error('Hostname is a string between 1 and 32 chars!');
			}
			this.hostname = hostname;
		
			this.apps = [];
		}

		get hostname(){
			return this._hostname;
		}
		set hostname(hostname){
			this._hostname = hostname;
		}

		get apps(){
			return this._apps;
		}
		set apps(apps){
			this._apps = apps;
		}

		search(pattern){

		}

		install(name){

		}

		uninstall(name){

		}

		listInstalled(){

		}

		update(){

		}
	}




let device = new Device('name', []);

console.log(device.hostname);