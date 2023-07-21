import { Menubar } from 'primereact/menubar';

const Navigation = () => {
     const navlist = [
        { label: 'Home', icon: 'pi pi-fw pi-home'},
        { label: 'About', icon: 'pi pi-fw pi-file' },
        { label: 'Contact', icon: 'pi pi-fw pi-phone',url:"/srt"}
    ];
    
    return(
        <div>
            <header>
                 <nav>
                    <ul>
                          <Menubar
                              model={navlist}
                          />
                    </ul>
                </nav>
            </header>
        </div>
    )
}
export default Navigation;