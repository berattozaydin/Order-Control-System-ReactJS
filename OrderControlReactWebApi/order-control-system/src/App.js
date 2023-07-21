import logo from './logo.svg';
import './App.css';
import 'primereact/resources/themes/saga-blue/theme.css';
import 'primereact/resources/primereact.min.css';
import 'primeicons/primeicons.css';
import { Dialog } from 'primereact/dialog';
import { InputText } from 'primereact/inputtext';
import { Accordion,AccordionTab } from 'primereact/accordion';
import { BrowserRouter, Routes, Route} from 'react-router-dom';
import Menubar  from './Components/AppMenu/AppMenuBar';
import  OrderPage  from './Components/Pages/OrderPage';

function App() {
  return (
    <div className="App">
             <div id="tpMenu" className="tp-menu-div">
            <div className="p-col">
                <Menubar />
            </div>
        </div>
        <div id="mainDiv" className="p-grid p-nogutter">
            <div className="p-col">
     <BrowserRouter>
        <Routes>
            <Route path='/srt' element={<OrderPage/>}/>
        </Routes>
      </BrowserRouter>
     </div>
     </div> 
    </div>
  );
}

export default App;
